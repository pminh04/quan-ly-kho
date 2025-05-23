﻿using System;
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
    public partial class taikhoan_tk_form : Form
    {
        public taikhoan_tk_form()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            loaddata.show_kh_tk(ncctk);
            ncctk.Columns["id"].HeaderText = "Mã khách hàng";
            ncctk.Columns["hoten"].HeaderText = "Tên khách hàng";
            ncctk.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ncctk.Columns["hoten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
