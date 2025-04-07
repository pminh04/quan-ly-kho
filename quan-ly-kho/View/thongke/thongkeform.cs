using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.Controller;
using quan_ly_kho.Model;

namespace quan_ly_kho.View.thongke
{
    public partial class thongkeform : Form
    {
        
        public thongkeform()
        {
            InitializeComponent();

        }

        private void thongkeform_Load(object sender, EventArgs e)
        {
            loaddata.show_thongke_sp(sptab);
            soluongsp.Text = DB.count("sanpham").ToString();
            soluongncc.Text = DB.count("nhacungcap").ToString();
            soluongtk.Text = DB.count("taikhoan").ToString();
            loaddata.show_cbx_xuatxu(xuatxucbx);
            loaislcbx.SelectedIndex = 0;
        }

        public void get_data()
        {

            thongke_model tk = new thongke_model(
                loaislcbx.Text,
                from.Text,
                to.Text,
                xuatxucbx.Text
                );
            loaddata.search_thongke(sptab, tk);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void xuatxucbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get_data();

        }

        private void loaislcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get_data(); 
        }
    }
}
