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

namespace quan_ly_kho.View.phieunhap
{
    public partial class formxemchitietphieunhap : Form
    {
        public formxemchitietphieunhap()
        {
            InitializeComponent();
            //LoadTable();
        }
        public void LoadData(DataTable dt)
        {
            tablenhaphang.DataSource = dt;
            tablenhaphang.Columns["maphieu"].HeaderText = "Mã phiếu nhập";
            tablenhaphang.Columns["masanpham"].HeaderText = "Mã sản phẩm";
            tablenhaphang.Columns["soluong"].HeaderText = "Số lượng";
            tablenhaphang.Columns["dongia"].HeaderText = "Đơn giá";
        }
        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formxemchitietphieunhap_Load(object sender, EventArgs e)
        {
            //LoadTable();
        }

        private void tablenhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
