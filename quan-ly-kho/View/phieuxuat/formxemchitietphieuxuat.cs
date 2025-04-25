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
using quan_ly_kho.Controller;

namespace quan_ly_kho.View.phieuxuat
{
    public partial class formxemchitietphieuxuat : Form
    {
        String table_name = "chitietphieuxuat";
        private string maphie;
        public formxemchitietphieuxuat(String maphieu)
        {
            this.maphie = maphieu;
            InitializeComponent();
            //LoadTable();
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formxemchitietphieuxuat_Load(object sender, EventArgs e)
        {
            loaddata.show_ctpxbyma(tablechitietphieuxuat, table_name, maphie);
        }

    }
}
