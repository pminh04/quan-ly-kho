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


namespace quan_ly_kho.View.nhaphang
{
    public partial class nhaphangform : Form
    {
        public nhaphangform()
        {
            InitializeComponent();
            LoadTable();
        }
        private void LoadTable()
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(selectedIndex >= 0 && selectedIndex < tablenhaphang.Rows.Count)
            {
                // Xóa dòng tại vị trí selectedIndex
                tablenhaphang.Rows.RemoveAt(selectedIndex);

                // Reset lại index để tránh lỗi khi click lại
                selectedIndex = -1;

                // Cập nhật lại STT và tổng tiền
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
            foreach (DataGridViewRow row in tablenhaphang.Rows)
            {
                row.Cells["STT"].Value = stt++;  // Cập nhật lại cột STT
            }
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;

            for (int i = 0; i < tablenhaphang.Rows.Count; i++)
            {
                // Nếu chưa phải là dòng mới (dòng trống cuối bảng)
                if (tablenhaphang.Rows[i].IsNewRow == false)
                {
                    object value = tablenhaphang.Rows[i].Cells["tongtien"].Value;

                    if (value != null && value.ToString() != "")
                    {
                        tong += Convert.ToDecimal(value);
                    }
                }
            }

            txttongtien.Text = tong.ToString("N0");
        }

        private int selectedIndex = -1;
        private void tablenhaphang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lưu lại chỉ số dòng được chọn
            selectedIndex = e.RowIndex;
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
                LoadSoLuongVaoNhapHang(masanpham, soluong, dongia);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maphieu = txtmaphieu.Text;
            string tennhacungcap = cbxnhacungcap.Text;
            string nguoitao = txtnguoitao.Text;
            DateTime thoigian = DateTime.Now;

            nhacungcapDAO dao = new nhacungcapDAO();
            string manhacungcap = dao.GetMaNhaCungCapByTen(tennhacungcap);
            if (string.IsNullOrEmpty(manhacungcap))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp trước khi lưu!");
                return;
            }

            float tongtien = Convert.ToSingle(txttongtien.Text); // lấy từ label tổng

            phieunhapmodel pn = new phieunhapmodel();
            pn.maphieu = maphieu;
            pn.nguoitao = nguoitao;
            pn.thoigiantao = thoigian;
            pn.manhacungcap = manhacungcap;
            pn.tongtien = tongtien;

            if (LuuPhieuNhap(pn))
            {
                LuuChiTietPhieuNhap(maphieu);
                MessageBox.Show("Nhập hàng thành công!");
                ResetFormNhapHang();
                // Có thể gọi hàm reset form tại đây nếu cần
            }
            else
            {
                MessageBox.Show("Lưu phiếu nhập thất bại!");
            }
        }

        private bool LuuPhieuNhap(phieunhapmodel pn)
        {
            phieunhapDAO dao = new phieunhapDAO();
            int kq = dao.Insert(pn);

            return kq > 0;
        }
        private void LuuChiTietPhieuNhap(string maphieu)
        {
            chitietphieunhapDAO dao = new chitietphieunhapDAO();
            sanphamDAO spDAO = new sanphamDAO();
            DataTable dtSanPham = spDAO.SelectExist();

            for (int i = 0; i < tablenhaphang.Rows.Count; i++)
            {
                DataGridViewRow row = tablenhaphang.Rows[i];

                // Bỏ qua dòng trống cuối cùng khi thêm dữ liệu
                if (!row.IsNewRow)
                {
                    chitietphieunhap.chitietphieunhapmodel ct = new chitietphieunhap.chitietphieunhapmodel();
                    ct.maphieu = maphieu;
                    ct.masanpham = row.Cells["masanpham"].Value.ToString();
                    ct.soluong = Convert.ToInt32(row.Cells["soluong"].Value);
                    ct.dongia = Convert.ToSingle(row.Cells["dongia"].Value);

                    dao.Insert(ct);
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
        private void ResetFormNhapHang()

        {
            LoadTable();
            // Xóa toàn bộ dòng trong bảng nhập hàng
            tablenhaphang.Rows.Clear();

            // Gán lại mã phiếu mới
            txtmaphieu.Text = TaoMaPhieuNhapTuDong();

            // Reset các ô nhập liệu khác nếu cần
            txtsoluong.Text = "1";
            txttongtien.Text = "0";
            cbxnhacungcap.SelectedIndex = 0;
        }

        private void nhaphang_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            txtnguoitao.Text = "admin";
            txtsoluong.Text = "1";
            if (string.IsNullOrEmpty(txtmaphieu.Text))
            {
                txtmaphieu.Text = TaoMaPhieuNhapTuDong();
            }
        }

        public string TaoMaPhieuNhapTuDong()
        {
            int stt = 1;
            string maPhieu;
            phieunhapDAO dao = new phieunhapDAO(); // hoặc this nếu đang trong DAO luôn

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
        private void LoadNhaCungCap()
        {
            nhacungcapDAO dao = new nhacungcapDAO();
            DataTable dt = dao.GetAll();

            if (dt != null && dt.Rows.Count > 0)
            {
                // Thêm dòng mặc định vào DataTable
                DataRow r = dt.NewRow();
                r["manhacungcap"] = "";
                r["tennhacungcap"] = "--- Chọn nhà cung cấp ---";
                dt.Rows.InsertAt(r, 0);

                cbxnhacungcap.DataSource = dt;
                cbxnhacungcap.DisplayMember = "tennhacungcap";
                cbxnhacungcap.ValueMember = "manhacungcap";
                cbxnhacungcap.SelectedIndex = 0; // hiển thị dòng mặc định
            }
            else
            {
                MessageBox.Show("Không có nhà cung cấp nào trong hệ thống.");
            }
        }
        private void LoadSoLuongVaoNhapHang(string masanpham, int soluong, decimal dongia)
        {
            bool isExist = false;

            for (int i = 0; i < tablenhaphang.Rows.Count; i++)
            {
                if (tablenhaphang.Rows[i].Cells["masanpham"].Value != null &&
                    tablenhaphang.Rows[i].Cells["masanpham"].Value.ToString() == masanpham)
                {
                    int currentSoluong = Convert.ToInt32(tablenhaphang.Rows[i].Cells["soluong"].Value);
                    currentSoluong += soluong;
                    decimal tongtien = currentSoluong * dongia;

                    tablenhaphang.Rows[i].Cells["soluong"].Value = currentSoluong;
                    tablenhaphang.Rows[i].Cells["dongia"].Value = dongia.ToString("#,##0.##");
                    tablenhaphang.Rows[i].Cells["tongtien"].Value = tongtien.ToString("#,##0.##");

                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                decimal tongtien = soluong * dongia;
                tablenhaphang.Rows.Add(
                    tablenhaphang.Rows.Count + 1,
                    masanpham,
                    soluong,
                    dongia.ToString("#,##0.##"),
                    tongtien.ToString("#,##0.##")
                );
            }

            CapNhatTongTien();
            CapNhatSTT();
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tablesanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
