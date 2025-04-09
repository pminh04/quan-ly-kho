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
    public partial class ncc_tk_form : Form
    {
        public ncc_tk_form()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            loaddata.show_ncc_tk(ncctk);
            ncctk.Columns["manhacungcap"].HeaderText = "Mã nhà cung cấp";
            ncctk.Columns["tennhacungcap"].HeaderText = "Tên nhà cung cấp";
            ncctk.Columns["manhacungcap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ncctk.Columns["tennhacungcap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
