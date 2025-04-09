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

namespace quan_ly_kho.View.thongke
{
    public partial class sanpham_tk_form : Form
    {
        public sanpham_tk_form()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
           loaddata.show_sp_tk(sptk);
           sptk.Columns["masanpham"].HeaderText = "Mã sản phẩm";
           sptk.Columns["tensanpham"].HeaderText = "Tên sản phẩm";
           sptk.Columns["masanpham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           sptk.Columns["tensanpham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
