
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
using static quan_ly_kho.Model.chitietphieuxuat_model;

namespace quan_ly_kho.View.phieuxuat
{
    public partial class formsuachitietphieuxuat : Form
    {
        private string maphieu;
        private int selectedIndex = -1;
        private mainform _mainForm;

        // Constructor nhận tham chiếu của mainform

        public formsuachitietphieuxuat(string maphieu)
        {
            InitializeComponent();
            this.maphieu = maphieu;
        }
        public formsuachitietphieuxuat(mainform mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void formsuachitietphieuxuat_Load(object sender, EventArgs e)
        {
            LoadPhieuXuat();
            LoadSanPham();
            LoadChiTietPhieu();
            LoadKhachHang();
        }

        private void LoadPhieuXuat()
        {
            phieuxuatDAO dao = new phieuxuatDAO();
            DataTable dt = dao.SelectById(maphieu);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtmaphieu.Text = row["maphieu"].ToString();
                txtnguoitao.Text = row["nguoitao"].ToString();
                txttongtien.Text = row["tongtien"].ToString();
                string makh = row["makhachhang"].ToString();

                KhachHangDAO khDAO = new KhachHangDAO();
                string tenkhachhang = khDAO.GetTenKhachHangByMa(makh);
                cbxkhachhang.SelectedValue = makh;

            }
        }
        private void LoadKhachHang()
        {
            KhachHangDAO dao = new KhachHangDAO();
            DataTable dt = dao.getAllKhachHang();

            if (dt != null && dt.Rows.Count > 0)
            {
                // Thêm dòng mặc định vào DataTable
                DataRow r = dt.NewRow();
                r["makhachhang"] = "";
                r["tenkhachhang"] = "--- Chọn khách hàng ---";
                dt.Rows.InsertAt(r, 0);

                cbxkhachhang.DataSource = dt;
                cbxkhachhang.DisplayMember = "tenkhachhang";
                cbxkhachhang.ValueMember = "makhachhang";
                cbxkhachhang.SelectedIndex = 0; // hiển thị dòng mặc định
            }
            else
            {
                MessageBox.Show("Không có khách hàng nào trong hệ thống.");
            }
        }
        private void LoadSanPham()
        {
            sanphamDAO dao = new sanphamDAO(); // khởi tạo DAO
            DataTable dt = dao.SelectExist();  // lấy sp có trạng thái = 1

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

        private void LoadChiTietPhieu()
        {
            chitietphieuxuatDAO dao = new chitietphieuxuatDAO();
            DataTable dt = dao.SelectByMaphieu(maphieu);

            foreach (DataRow row in dt.Rows)
            {
                int soluong = Convert.ToInt32(row["soluong"]);
                float dongia = float.Parse(row["dongia"].ToString());
                decimal tongtien = (decimal)(soluong * dongia);

                tablexuathang.Rows.Add(
                    tablexuathang.Rows.Count + 1,
                    row["masanpham"].ToString(),
                    soluong,
                    dongia,
                    tongtien
                );
            }

            CapNhatTongTien();
            CapNhatSTT();
        }
        private bool SuaPhieuXuat(phieuxuatmodel px)
        {
            phieuxuatDAO dao = new phieuxuatDAO();
            int kq = dao.Update(px);

            return kq > 0;
        }
        private void SuaChiTietPhieuXuat(string maphieu)
        {
            chitietphieuxuatDAO dao = new chitietphieuxuatDAO();

            sanphamDAO spDAO = new sanphamDAO();
            DataTable dtSanPham = spDAO.SelectExist();

            for (int i = 0; i < tablexuathang.Rows.Count; i++)
            {
                DataGridViewRow row = tablexuathang.Rows[i];

                // Bỏ qua dòng trống cuối cùng khi thêm dữ liệu
                if (!row.IsNewRow)
                {
                    chitietphieuxuat ct = new chitietphieuxuat();
                    ct.maphieu = maphieu;
                    ct.masanpham = row.Cells["masanpham"].Value.ToString();
                    ct.soluong = Convert.ToInt32(row.Cells["soluong"].Value);
                    ct.dongia = Convert.ToSingle(row.Cells["dongia"].Value);
                    //dao.DeleteByMaphieu(maphieu);
                    dao.Update(ct);
                    DataRow[] found = dtSanPham.Select("masanpham = '" + ct.masanpham + "'");
                    if (found.Length > 0)
                    {
                        int soluongHienTai = Convert.ToInt32(found[0]["soluong"]);
                        int soluongMoi = soluongHienTai + ct.soluong;
                        spDAO.UpdateSoLuong(ct.masanpham, soluongMoi);
                    }
                }

            }
        }
        private void LoadSoLuongVaoXuatHang(string masanpham, int soluong, decimal dongia)
        {
            bool isExist = false;

            // Duyệt qua các dòng để kiểm tra trùng mã
            for (int i = 0; i < tablexuathang.Rows.Count; i++)
            {
                if (tablexuathang.Rows[i].Cells["masanpham"].Value != null &&
                    tablexuathang.Rows[i].Cells["masanpham"].Value.ToString() == masanpham)
                {
                    // Nếu đã có, cộng dồn số lượng và cập nhật lại tổng tiền
                    int currentSoluong = Convert.ToInt32(tablexuathang.Rows[i].Cells["soluong"].Value);
                    currentSoluong += soluong;

                    tablexuathang.Rows[i].Cells["soluong"].Value = currentSoluong;
                    tablexuathang.Rows[i].Cells["tongtien"].Value = currentSoluong * dongia;

                    isExist = true;
                    break;
                }
            }

            // Nếu chưa có thì thêm mới sau khi kiểm tra hết
            if (!isExist)
            {
                decimal tongtien = soluong * dongia;
                tablexuathang.Rows.Add(
                    tablexuathang.Rows.Count + 1, // STT
                    masanpham,
                    soluong,
                    dongia,
                    tongtien
                );
            }

            // Cập nhật tổng tiền
            CapNhatTongTien();
            CapNhatSTT();
        }
        private void CapNhatSTT()
        {
            int stt = 1;
            foreach (DataGridViewRow row in tablexuathang.Rows)
            {
                row.Cells["STT"].Value = stt++;  // Cập nhật lại cột STT
            }
        }
        private void CapNhatTongTien()
        {
            decimal tong = 0;

            for (int i = 0; i < tablexuathang.Rows.Count; i++)
            {
                // Nếu chưa phải là dòng mới (dòng trống cuối bảng)
                if (tablexuathang.Rows[i].IsNewRow == false)
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

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            String maphieu = txtmaphieu.Text;
            string tenkhachhang = cbxkhachhang.Text;
            string nguoitao = txtnguoitao.Text;
            DateTime thoigian = DateTime.Now;

            KhachHangDAO dao = new KhachHangDAO();
            string makhachhang = dao.GetMaKhachHangByTen(tenkhachhang);
            if (string.IsNullOrEmpty(makhachhang))
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi lưu!");
                return;
            }

            float tongtien = Convert.ToSingle(txttongtien.Text); // lấy từ label tổng

            phieuxuatmodel px = new phieuxuatmodel();
            px.maphieu = maphieu;
            px.nguoitao = nguoitao;
            px.thoigiantao = thoigian;
            px.makhachhang = makhachhang;
            px.tongtien = tongtien;
            chitietphieuxuatDAO ct = new chitietphieuxuatDAO();


            if (SuaPhieuXuat(px))
            {
                SuaChiTietPhieuXuat(maphieu);
                MessageBox.Show("Sửa thành công!");

                ResetFormXuatHang();
                // Có thể gọi hàm reset form tại đây nếu cần
            }
            else
            {
                MessageBox.Show("Lưu phiếu nhập thất bại!");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (tablesanpham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm.");
                return;
            }
            else
            {
                // Lấy thông tin sản phẩm từ dòng được chọn
                DataGridViewRow row = tablesanpham.SelectedRows[0];
                string masanpham = row.Cells["masanpham"].Value.ToString();

                decimal dongia = Convert.ToDecimal(row.Cells["dongia"].Value);

                // Lấy số lượng từ TextBox (nếu không nhập thì mặc định là 1)
                int soluong = 1;
                if (!string.IsNullOrEmpty(txtsoluong.Text))
                {
                    int.TryParse(txtsoluong.Text, out soluong);
                }

                // Gọi hàm thêm hoặc cập nhật sản phẩm vào bảng nhập hàng
                LoadSoLuongVaoXuatHang(masanpham, soluong, dongia);
            }
        }

        private void formsuachitietphieuxuat_Load_1(object sender, EventArgs e)
        {
            txtsoluong.Text = "1";
            LoadKhachHang();
            LoadPhieuXuat();
            LoadSanPham();
            LoadChiTietPhieu();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tablexuathang.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                int selectedIndex = tablexuathang.SelectedRows[0].Index;

                // Xóa dòng tại vị trí selectedIndex
                tablexuathang.Rows.RemoveAt(selectedIndex);

                // Cập nhật lại số thứ tự và tổng tiền
                CapNhatSTT();
                CapNhatTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng muốn xóa.");
            }
        }

        private void tablexuathang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string TaoMaPhieuXuatTuDong()
        {
            int stt = 1;
            string maPhieu;
            phieuxuatDAO dao = new phieuxuatDAO(); // hoặc this nếu đang trong DAO luôn

            while (true)
            {
                maPhieu = "MP" + stt;

                DataTable dt = dao.SelectById(maPhieu); // gọi hàm bạn đã có
                if (dt.Rows.Count == 0)
                {
                    break; // không trùng, dùng mã này
                }

                stt++; // tăng nếu trùng
            }

            return maPhieu;
        }
        private void ResetFormXuatHang()

        {
            LoadSanPham();
            // Xóa toàn bộ dòng trong bảng nhập hàng
            tablexuathang.Rows.Clear();

            // Gán lại mã phiếu mới
            txtmaphieu.Text = TaoMaPhieuXuatTuDong();

            // Reset các ô nhập liệu khác nếu cần
            txtsoluong.Text = "1";
            txttongtien.Text = "0";
            cbxkhachhang.SelectedIndex = 0;
        }
        private void tablexuathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablexuathang.SelectedRows.Count > 0)
            {
                selectedIndex = tablexuathang.SelectedRows[0].Index;  // Lấy index của dòng được chọn
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

        private void cbxkhachhang_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}

