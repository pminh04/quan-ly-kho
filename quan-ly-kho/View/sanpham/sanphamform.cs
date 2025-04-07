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
using quan_ly_kho.View.nhacungcap;

namespace quan_ly_kho.View.sanpham
{
    public partial class sanphamform : Form
    {
        public sanphamform()
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
            }
            else
            {
                tablesanpham.DataSource = null;
                MessageBox.Show("Không có dữ liệu.");
            }
        }

        private int selectedIndex = -1;
        private void tablesanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa");
                return;
            }

            string masp = tablesanpham.Rows[selectedIndex].Cells["masanpham"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sanphamDAO dao = new sanphamDAO();
                dao.DeleteTrangThai(masp); // Chuyển trạng thái về 0
                LoadTable(); // Load lại bảng
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa");
                return;
            }

            // Lấy dữ liệu từ dòng được chọn
            string masanpham = tablesanpham.Rows[selectedIndex].Cells["masanpham"].Value.ToString();
            string tensanpham = tablesanpham.Rows[selectedIndex].Cells["tensanpham"].Value.ToString();
            string xuatxu = tablesanpham.Rows[selectedIndex].Cells["xuatxu"].Value.ToString();
            int soluong = int.Parse(tablesanpham.Rows[selectedIndex].Cells["soluong"].Value.ToString());
            decimal dongia = decimal.Parse(tablesanpham.Rows[selectedIndex].Cells["dongia"].Value.ToString());

            // Truyền sang Form sửa (giả sử bạn truyền qua constructor)
            updatesanpham form = new updatesanpham(masanpham, tensanpham, xuatxu, soluong, dongia);
            form.ShowDialog();

            // Sau khi sửa xong load lại bảng
            LoadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addsanpham f1 = new addsanpham();
            f1.BringToFront();
            f1.Show();
        }
    }
}
