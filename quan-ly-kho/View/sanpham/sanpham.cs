using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tu.database;

namespace tu
{
    public partial class sanpham : Form
    {
        public sanpham()
        {
            InitializeComponent();
            LoadTable();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthemsp_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnloadanh_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnupdate_Click(object sender, EventArgs e)
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private int selectedIndex = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
