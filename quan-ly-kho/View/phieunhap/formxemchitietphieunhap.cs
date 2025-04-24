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
    public partial class formxemchitietphieunhap : Form
    {
        String table_name = "chitietphieunhap";
        private string maphie;
        public formxemchitietphieunhap( String maphieu)
        {
            this.maphie = maphieu;
            InitializeComponent();
            //LoadTable();
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
            loaddata.show_ctpnbyma(tablechitietphieunhap, table_name, maphie);
        }

        private void tablenhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablenhaphang_Click(object sender, EventArgs e)
        {

        }
    }
}
