
using System.Net.NetworkInformation;
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
using static quan_ly_kho.Model.chitietphieunhap;
using quan_ly_kho.Controller;

namespace quan_ly_kho.View.phieunhap
{
    public partial class formsuachitietphieunhap : Form
    {
        private string maphieu;
        private int selectedIndex = -1;
        string table_name = "sanpham";
        phieunhapmodel phieunhap;
        // Constructor nhận tham chiếu của mainform
        DataTable dtNhapHang = new DataTable();

        public formsuachitietphieunhap(Model.phieunhapmodel pn)
        {
            phieunhap = pn;
            InitializeComponent();
            dtNhapHang.Columns.Add("masanpham");
            dtNhapHang.Columns.Add("soluong", typeof(int));
            dtNhapHang.Columns.Add("dongia", typeof(double));
            dtNhapHang.Columns.Add("tongtien", typeof(double));

            tablenhaphang.DataSource = dtNhapHang;


        }
        public formsuachitietphieunhap(mainform mainForm)
        {
            InitializeComponent();
            
        }

        private void formsuachitietphieunhap_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadNhaCungCap()
        {
            string sql = "SELECT * FROM nhacungcap";
            DB.loadcbox(cbxnhacungcap, sql, "tennhacungcap", "manhacungcap");
        }
      
        private void LoadChiTietPhieu()
        {
            loaddata.show_ctpnbyma(tablenhaphang, "chitietphieunhap", txtmaphieu.Text);

           
            
        }
        private bool SuaPhieuNhap(phieunhapmodel pn)
        {
            phieunhapDAO dao = new phieunhapDAO();
            int kq = dao.Update(pn);

            return kq > 0;
        }
        private void SuaChiTietPhieuNhap(string maphieu)
        {
            //chitietphieunhapDAO dao = new chitietphieunhapDAO();

            //sanphamDAO spDAO = new sanphamDAO();
            //DataTable dtSanPham = spDAO.SelectExist();

            //for (int i = 0; i < tablenhaphang.Rows.Count; i++)
            //{
            //    DataGridViewRow row = tablenhaphang.Rows[i];

            //    // Bỏ qua dòng trống cuối cùng khi thêm dữ liệu
            //    if (!row.IsNewRow)
            //    {
            //        chitietphieunhapmodel ct = new chitietphieunhapmodel();
            //        ct.maphieu = maphieu;
            //        ct.masanpham = row.Cells["masanpham"].Value.ToString();
            //        ct.soluong = Convert.ToInt32(row.Cells["soluong"].Value);
            //        ct.dongia = Convert.ToSingle(row.Cells["dongia"].Value);
            //        //dao.DeleteByMaphieu(maphieu);
            //        dao.Update(ct);
            //        DataRow[] found = dtSanPham.Select("masanpham = '" + ct.masanpham + "'");
            //        if (found.Length > 0)
            //        {
            //            int soluongHienTai = Convert.ToInt32(found[0]["soluong"]);
            //            int soluongMoi = soluongHienTai + ct.soluong;
            //            spDAO.UpdateSoLuong(ct.masanpham, soluongMoi);
            //        }
            //    }

            //}
        }


        private void CapNhatThanhTien()
        {
            double tong = 0;

            // Duyệt qua các dòng trong tablenhaphang và cộng tổng tiền
            foreach (DataGridViewRow row in tablenhaphang.Rows)
            {
                // Nếu dòng không phải là dòng mới (dòng trắng cuối bảng)
                if (row.Cells["tongtien"].Value != null)
                {
                    tong += Convert.ToSingle(row.Cells["tongtien"].Value);
                }
            }

            // Cập nhật tổng tiền vào TextBox
            txtthanhtien.Text = tong.ToString("N0");
        }


        private void btncapnhat_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string maphieu = txtmaphieu.Text;
            //    string nguoitao = txtnguoitao.Text;
            //    DateTime thoigian = DateTime.Now;
            //    string nhacungcap = cbxnhacungcap.SelectedValue.ToString();
            //    if (string.IsNullOrEmpty(nhacungcap))
            //    {
            //        MessageBox.Show("Vui lòng chọn nhà cung cấp trước khi lưu!");
            //        return;
            //    }

            //    float tongtien = Convert.ToSingle(txtthanhtien.Text); // lấy từ label tổng

            //    Model.phieunhapmodel pn = new Model.phieunhapmodel(
            //        maphieu,
            //        thoigian,
            //        nguoitao,
            //        nhacungcap,
            //        tongtien

            //    ); Controller.Sua.sua_pn(pn);
            //    //LuuChiTietPhieuNhap();
            //    MessageBox.Show("Nhập hàng thành công!");
            //    ResetFormNhapHang();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Sửa phiếu nhập thất bại!" + ex.Message);
            //}
        }
        private String selectedma;
        private String selectedten;
        private String selectedxuatxu;
        private String selectedmaloai;
        private int selectedsoluong;
        private void btnthem_Click(object sender, EventArgs e)
        {
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
            if (!double.TryParse(txtdongia.Text, out double dongia) || dongia <= 0)
            {
                MessageBox.Show("Đơn giá phải là số dương.");
                return;
            }
            bool tonTai = false;
            foreach (DataGridViewRow row in tablenhaphang.Rows)
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

                // Tính thành tiền (float)
                double tongtien = dongia * soluong;

                // Đẩy dữ liệu sang bảng tablenhaphang
                dtNhapHang.Rows.Add(
                    selectedma,
                    soluong,
                    dongia,
                    tongtien
                );
            }
            CapNhatThanhTien();
        }

        private void formsuachitietphieunhap_Load_1(object sender, EventArgs e)
        {
            txtsoluong.Text = "1";
            loaddata.show_sp(tablesanpham, table_name);
            LoadNhaCungCap(); // PHẢI gọi trước khi set SelectedValue

            txtmaphieu.Text = phieunhap.maphieu;
            txtnguoitao.Text = phieunhap.nguoitao;
            cbxnhacungcap.SelectedValue = phieunhap.manhacungcap; // Gán sau khi load nguồn dữ liệu
            txtthanhtien.Text = phieunhap.tongtien.ToString();

            LoadChiTietPhieu();


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tablenhaphang.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                int selectedIndex = tablenhaphang.SelectedRows[0].Index;

                // Xóa dòng tại vị trí selectedIndex
                tablenhaphang.Rows.RemoveAt(selectedIndex);

                // Cập nhật lại số thứ tự và tổng tiền

               // CapNhatThanhTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa.");
            }
        }

        private void tablenhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void ResetFormNhapHang()

        {
            tablenhaphang.Rows.Clear();
            txtmaphieu.Text = TaoMaPhieuNhapTuDong();
            loaddata.show_sp(tablesanpham, table_name);
            txtsoluong.Text = "1";
            txtthanhtien.Text = "0";
            cbxnhacungcap.SelectedIndex = 0;
        }
        private string selectedmasanpham;
        private int selectedsl;
        private double selecteddongia;
        private double selectedtongtien;
        private void tablenhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0) // Đảm bảo chỉ xử lý khi có hàng được chọn
            {
                //string selectedmaphieu = tablenhaphang.Rows[i].Cells["maphieu"].Value.ToString();
                selectedmasanpham = tablenhaphang.Rows[i].Cells["masanpham"].Value.ToString();
                selectedsl = (int)tablenhaphang.Rows[i].Cells["soluong"].Value;
                selecteddongia = Convert.ToSingle(tablenhaphang.Rows[i].Cells["dongia"].Value);
                selectedtongtien = Convert.ToSingle(tablenhaphang.Rows[i].Cells["tongtien"].Value);

            }
        }


        private void tablesanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtnguoitao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbxnhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmaphieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablesanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0) // Đảm bảo chỉ xử lý khi có hàng được chọn
            {
                selectedma = tablesanpham.Rows[i].Cells["masp"].Value.ToString();
                selectedten = tablesanpham.Rows[i].Cells["tensp"].Value.ToString();
                selectedxuatxu = tablesanpham.Rows[i].Cells["xuatxu"].Value.ToString();
                selectedmaloai = tablesanpham.Rows[i].Cells["maloaihang"].Value.ToString();
                selectedsoluong = (int)tablesanpham.Rows[i].Cells["sl"].Value;

            }
        }
    }
}
