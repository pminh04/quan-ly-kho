using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.Controller;
using quan_ly_kho.DAO;
using quan_ly_kho.Model;


namespace quan_ly_kho.View.xuatphang
{
    public partial class xuathangform : Form
    {
        public void Loaddgv(DataTable dt)
        {
            tablesanpham.DataSource = dt;
        }
        public xuathangform()
        {
            InitializeComponent();
            tablexuathang.Columns["tongtien"].DefaultCellStyle.Format = "#,##0.##";


        }
        string table_name = "sanpham";


        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tablexuathang.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in tablexuathang.SelectedRows)
                {
                    tablexuathang.Rows.Remove(row);
                }
            }
            CapNhatThanhTien();
        }



        private void CapNhatThanhTien()
        {
            double tong = 0;

            for (int i = 0; i < tablexuathang.Rows.Count; i++)
            {
                // Nếu chưa phải là dòng mới (dòng trống cuối bảng)
                if (tablexuathang.Rows[i].Cells["tongtien"].Value != null)
                {
                    tong += (double)tablexuathang.Rows[i].Cells["tongtien"].Value;
                }
            }

            txtthanhtien.Text = tong.ToString("N0");
        }

        private int selectedIndex = -1;
        private void tablenhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lưu lại chỉ số dòng được chọn
            selectedIndex = e.RowIndex;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //Model.SanPhamModel sp = new Model.SanPhamModel(selectedma, selectedten, selectedxuatxu, selectedmaloai, selectedsoluong);
            if (selectedma == null)
            {
                MessageBox.Show("Vui long chọn dữ liệu cần sửa.");
                return;
            }
            // Kiểm tra số lượng nhập
            if (!int.TryParse(txtsoluong.Text, out int soluong) || soluong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương.");
                return;
            }

            // Kiểm tra đơn giá nhập (float)
            if (!float.TryParse(txtdongia.Text, out float dongia) || dongia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số dương.");
                return;
            }
            bool tonTai = false;
            foreach (DataGridViewRow row in tablexuathang.Rows)
            {
                if (row.Cells["masanpham"].Value?.ToString() == selectedma)
                {
                    int slCu = Convert.ToInt32(row.Cells["soluong"].Value);
                    row.Cells["soluong"].Value = slCu + soluong;
                    row.Cells["dongia"].Value = dongia;
                    row.Cells["tongtien"].Value = (slCu + soluong) * dongia;
                    tonTai = true;
                    break;
                }
            }

            if (!tonTai)
            {

                // Tính thành tiền (double)
                double tongtien = dongia * soluong;

                // Đẩy dữ liệu sang bảng tablenhaphang
                tablexuathang.Rows.Add(
                    selectedma,

                    soluong,
                    dongia,
                    tongtien
                );
            }
            CapNhatThanhTien();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string maphieu = txtmaphieu.Text;
                string nguoitao = txtnguoitao.Text;
                DateTime thoigian = DateTime.Now;
                string nhacungcap = cbxkhachhang.SelectedValue.ToString();
                if (string.IsNullOrEmpty(nhacungcap))
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp trước khi lưu!");
                    return;
                }

                float tongtien = Convert.ToSingle(txtthanhtien.Text); // lấy từ label tổng

                Model.phieunhapmodel pn = new Model.phieunhapmodel(
                    maphieu,
                    thoigian,
                    nguoitao,
                    nhacungcap,
                    tongtien

     ); Controller.Them.them_pn(pn);
                LuuChiTietPhieuNhap();
                MessageBox.Show("Nhập hàng thành công!");
                ResetFormNhapHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu phiếu nhập thất bại!" + ex.Message);
            }
        }


        private void LuuChiTietPhieuNhap()
        {
            try
            {
                foreach (DataGridViewRow row in tablexuathang.Rows)
                {
                    if (!row.IsNewRow) // Bỏ qua dòng trắng cuối
                    {
                        Model.chitietphieunhap ctpn = new Model.chitietphieunhap();

                        ctpn.maphieu = txtmaphieu.Text;
                        ctpn.masanpham = row.Cells["masanpham"].Value.ToString();
                        ctpn.soluong = Convert.ToInt32(row.Cells["soluong"].Value);
                        ctpn.dongia = float.Parse(row.Cells["dongia"].Value.ToString());
                        ctpn.tongtien = float.Parse(row.Cells["tongtien"].Value.ToString());

                        Controller.Them.them_ctpn(ctpn);
                        Controller.Sua.UpdateSoLuong(ctpn.masanpham, ctpn.soluong);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu phiếu nhập thất bại!" + ex.Message);
            }

        }
        private void ResetFormNhapHang()

        {
            tablexuathang.Rows.Clear();
            txtmaphieu.Text = TaoMaPhieuNhapTuDong();
            loaddata.show_sp(tablesanpham, table_name);
            txtsoluong.Text = "1";
            txtthanhtien.Text = "0";
            cbxkhachhang.SelectedIndex = 0;
        }

        private void nhaphang_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            loaddata.show_sp(tablesanpham, table_name);
            txtnguoitao.Text = "admin";
            txtsoluong.Text = "1";
            if (string.IsNullOrEmpty(txtmaphieu.Text))
            {
                txtmaphieu.Text = TaoMaPhieuNhapTuDong();
            }
            //CapNhatThanhTien();


        }

        public string TaoMaPhieuNhapTuDong()
        {
            int stt = 1;
            while (DB.searchbyid("phieunhap", "MP" + stt, "maphieu") != null)
            {
                stt++;
            }
            return "MP" + stt;
        }
        private void LoadNhaCungCap()
        {
            string sql = "SELECT * FROM nhacungcap";
            DB.loadcbox(cbxkhachhang, sql, "tennhacungcap", "manhacungcap");
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tablenhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private String selectedma;
        private String selectedten;
        private String selectedxuatxu;
        private String selectedmaloai;
        private int selectedsoluong;
        private void tablesanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0) // Đảm bảo chỉ xử lý khi có hàng được chọn
            {
                selectedma = tablesanpham.Rows[i].Cells["masp"].Value.ToString();
                selectedten = tablesanpham.Rows[i].Cells["tensp"].Value.ToString();
                selectedxuatxu = tablesanpham.Rows[i].Cells["xuatxu"].Value.ToString();
                selectedmaloai = tablesanpham.Rows[i].Cells["tenloaihang"].Value.ToString();
                selectedsoluong = (int)tablesanpham.Rows[i].Cells["sl"].Value;

            }
        }

        private void tablesanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
