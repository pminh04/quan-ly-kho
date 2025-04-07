using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho;

namespace quan_ly_kho.View.sanpham
{
    public partial class sanpham : Form
    {
        public sanpham()
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
    }
}
