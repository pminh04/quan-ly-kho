using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.DAO;
using quan_ly_kho.Model;
using static quan_ly_kho.Model.chitietphieuxuatmodel;

namespace quan_ly_kho.View.xuathang
{
    public partial class xuathangform: Form
    {
        public xuathangform()
        {
            InitializeComponent();
            LoadTable();
        }
        private void LoadTable()
        {
            sanphamDAO dao = new sanphamDAO();
            DataTable dt = dao.SelectExist();

            if (dt != null && dt.Rows.Count > 0)
            {
                tablesanpham.DataSource = dt;
                tablesanpham.Columns["masanpham"].HeaderText = "Mã sản phẩm";
                tablesanpham.Columns["tensanpham"].HeaderText = "Tên sản phẩm";
                tablesanpham.Columns["xuatxu"].HeaderText = "Xuất xứ";
                tablesanpham.Columns["soluong"].HeaderText = "Số lượng";
                tablesanpham.Columns["dongia"].HeaderText = "Đơn giá";
                tablesanpham.Columns["dongia"].DefaultCellStyle.Format = "#,##0.##";
            }
            else
            {
                tablesanpham.DataSource = null;
                MessageBox.Show("Không có dữ liệu.");
            }
        }
        private int selectedIndex = -1;
        private void xuathang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            txtnguoitao.Text = "admin";
            txtsoluong.Text = "1";
            if (string.IsNullOrEmpty(txtmaphieu.Text))
            {
                txtmaphieu.Text = TaoMaPhieuXuatTuDong();
            }
        }

        private void tablesanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablexuathang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablexuathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0 && selectedIndex < tablexuathang.Rows.Count)
            {
                tablexuathang.Rows.RemoveAt(selectedIndex);
                selectedIndex = -1;
                CapNhatSTT();
                CapNhatTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa.");
            }
        }
        private void CapNhatSTT()
        {
            int stt = 1;
            foreach (DataGridViewRow row in tablexuathang.Rows)
            {
                row.Cells["STT"].Value = stt++;
            }
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;
            for (int i = 0; i < tablexuathang.Rows.Count; i++)
            {
                if (!tablexuathang.Rows[i].IsNewRow)
                {
                    object value = tablexuathang.Rows[i].Cells["tongtien"].Value;
                    if (value != null && value.ToString() != "")
                    {
                        tong += Convert.ToDecimal(value);
                    }
                }
            }
            txttongtien.Text = tong.ToString("N0");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (tablesanpham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm.");
                return;
            }

            DataGridViewRow row = tablesanpham.SelectedRows[0];
            if (tablesanpham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm.");
                return;
            }

            //DataGridViewRow row = tablesanpham.SelectedRows[0];
            string masanpham = row.Cells["masanpham"].Value.ToString();
            int soluongTon = Convert.ToInt32(row.Cells["soluong"].Value); // số lượng tồn kho
            decimal dongia = Convert.ToDecimal(row.Cells["dongia"].Value);

            // Kiểm tra số lượng muốn xuất
            int soluong = 1;
            if (!string.IsNullOrEmpty(txtsoluong.Text))
            {
                if (!int.TryParse(txtsoluong.Text, out soluong) || soluong <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng hợp lệ (> 0).");
                    return;
                }

                if (soluong > soluongTon)
                {
                    MessageBox.Show("Số lượng xuất vượt quá số lượng tồn kho.");
                    return;
                }
            }

            // Thêm vào bảng chi tiết phiếu xuất
            LoadSoLuongVaoXuatHang(masanpham, soluong, dongia);
        }
        private void LoadSoLuongVaoXuatHang(string masanpham, int soluong, decimal dongia)
        {
            bool isExist = false;
            for (int i = 0; i < tablexuathang.Rows.Count; i++)
            {
                if (tablexuathang.Rows[i].Cells["masanpham"].Value != null &&
                    tablexuathang.Rows[i].Cells["masanpham"].Value.ToString() == masanpham)
                {
                    int currentSoluong = Convert.ToInt32(tablexuathang.Rows[i].Cells["soluong"].Value);
                    currentSoluong += soluong;
                    decimal tongtien = currentSoluong * dongia;

                    tablexuathang.Rows[i].Cells["soluong"].Value = currentSoluong;
                    tablexuathang.Rows[i].Cells["dongia"].Value = dongia.ToString("#,##0.##");
                    tablexuathang.Rows[i].Cells["tongtien"].Value = tongtien.ToString("#,##0.##");

                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                decimal tongtien = soluong * dongia;
                tablexuathang.Rows.Add(
                    tablexuathang.Rows.Count + 1,
                    masanpham,
                    soluong,
                    dongia.ToString("#,##0.##"),
                    tongtien.ToString("#,##0.##")
                );
            }

            CapNhatTongTien();
            CapNhatSTT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maphieu = txtmaphieu.Text;
            string tenkhachhang = cbxkhachhang.Text;
            string nguoitao = txtnguoitao.Text;
            DateTime thoigian = DateTime.Now;

            KhachHangDAO daoKH = new KhachHangDAO();
            string makhachhang = cbxkhachhang.SelectedValue.ToString();
            if (string.IsNullOrEmpty(makhachhang))
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi lưu!");
                return;
            }


            float tongtien = Convert.ToSingle(txttongtien.Text);

            phieuxuatmodel px = new phieuxuatmodel();
            px.maphieu = maphieu;
            px.nguoitao = nguoitao;
            px.thoigiantao = thoigian;
            px.makhachhang = makhachhang;
            px.tongtien = tongtien;

            if (LuuPhieuXuat(px))
            {
                LuuChiTietPhieuXuat(maphieu);
                MessageBox.Show("Xuất hàng thành công!");
                ResetFormXuatHang();
            }
            else
            {
                MessageBox.Show("Lưu phiếu xuất thất bại!");
            }
        }
        private bool LuuPhieuXuat(phieuxuatmodel px)
        {
            phieuxuatDAO dao = new phieuxuatDAO();
            int kq = dao.Insert(px);
            return kq > 0;
        }

        private void LuuChiTietPhieuXuat(string maphieu)
        {
            chitietphieuxuatDAO dao = new chitietphieuxuatDAO();
            sanphamDAO spDAO = new sanphamDAO();

            for (int i = 0; i < tablexuathang.Rows.Count; i++)
            {
                DataGridViewRow row = tablexuathang.Rows[i];
                if (!row.IsNewRow)
                {
                    chitietphieuxuatmodel ct = new chitietphieuxuatmodel();
                    ct.maphieu = maphieu;
                    ct.masanpham = row.Cells["masanpham"].Value.ToString();
                    ct.soluong = Convert.ToInt32(row.Cells["soluong"].Value);
                    ct.dongia = Convert.ToSingle(row.Cells["dongia"].Value);

                    dao.Insert(ct);

                    // Trừ số lượng tồn kho
                    spDAO.TruSoLuong(ct.masanpham, ct.soluong);
                }
            }
        }


        private void ResetFormXuatHang()
        {
            LoadTable();
            tablexuathang.Rows.Clear();
            txtmaphieu.Text = TaoMaPhieuXuatTuDong();
            txtsoluong.Text = "1";
            txttongtien.Text = "0";
            cbxkhachhang.SelectedIndex = 0;
        }

        public string TaoMaPhieuXuatTuDong()
        {
            int stt = 1;
            string maPhieu;
            phieuxuatDAO dao = new phieuxuatDAO();

            while (true)
            {
                maPhieu = "PX" + stt;
                DataTable dt = dao.SelectById(maPhieu);
                if (dt.Rows.Count == 0)
                {
                    break;
                }
                stt++;
            }
            return maPhieu;
        }
        private void LoadKhachHang()
        {
            KhachHangDAO dao = new KhachHangDAO();
            DataTable dt = dao.getAllKhachHang();
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow r = dt.NewRow();
                r["id"] = "";
                r["hoten"] = "--- Chọn khách hàng ---";
                dt.Rows.InsertAt(r, 0);

                cbxkhachhang.DataSource = dt;
                cbxkhachhang.DisplayMember = "hoten";  // sửa lại
                cbxkhachhang.ValueMember = "id";       // sửa lại
                cbxkhachhang.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Không có khách hàng nào trong hệ thống.");
            }
        }

        private void tablesanpham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
