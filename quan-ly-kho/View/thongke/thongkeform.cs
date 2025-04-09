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
            loaddata.show_thongke_kh(tabkh);
            loaddata.show_thongke_sp(sptab);
            soluongsp.Text = DB.count("sanpham where trangthai = 1").ToString();
            soluongncc.Text = DB.count("nhacungcap").ToString();
            soluongtk.Text = DB.count("khachhang").ToString();
            loaddata.show_cbx_xuatxu(xuatxucbx);
            loaislcbx.SelectedIndex = 0;
        }

        public void search_data_sp()
        {

            thongke_model_sp tk = new thongke_model_sp(
                loaislcbx.Text,
                from.Text,
                to.Text,
                xuatxucbx.Text
                );
            loaddata.search_thongke_sp(sptab, tk);
        }
        public void search_data_kh()
        {

            thongke_model_kh tk_kh = new thongke_model_kh(
                khfrom.Text,
                khto.Text,
                tienfrom.Text,
                tiento.Text
                );
            loaddata.search_thongke_kh(tabkh, tk_kh);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void xuatxucbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void loaislcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void timkiem_sp_Click(object sender, EventArgs e)
        {
            search_data_sp();
        }

        private void timkiem_kh_Click(object sender, EventArgs e)
        {
            search_data_kh();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            sanpham_tk_form sp = new sanpham_tk_form();
            sp.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            ncc_tk_form ncc = new ncc_tk_form();
            ncc.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            taikhoan_tk_form tk = new taikhoan_tk_form();
            tk.Show();
        }
    }
}
