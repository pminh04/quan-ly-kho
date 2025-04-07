using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.View.phieunhap;
using quan_ly_kho.View.sanpham;

namespace quan_ly_kho
{
    public partial class mainform : Form
    {
        //button colo
        private Color defaultColor = Color.FromArgb(0, 128, 0);
        private Color activeColor = Color.FromArgb(76, 175, 80);
        private Button[] buttons;

        private void ChangeButtonColor(Button clickedButton)
        {
            if (clickedButton == null) return;

            foreach (Button btn in buttons)
            {
                btn.BackColor = defaultColor;
            }

            
            clickedButton.BackColor = activeColor;
        }

        //
        public mainform()
        {
            InitializeComponent();
            //button color
            buttons = new Button[] { sanpham, nhacungcap, khachhang, nhaphang, phieunhap,xuathang,phieuxuat,thongke,taikhoan };

            // Wire up events and set initial colors
            foreach (Button btn in buttons)
            {
                btn.Click += (s, e) => ChangeButtonColor(s as Button);
                btn.BackColor = defaultColor;
            }
            //

            //timkiemcbx
            //timkiemcbx.AutoSize = false;
            //timkiemcbx.Size = new Size(103, 30);
            //
        }

        

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sanpham_Click(object sender, EventArgs e)
        {
            sanphamform f1 = new sanphamform();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (showform.Controls.Count > 0)
            {
                showform.Controls.Clear();
            }
            showform.Controls.Add(f1);
            f1.BringToFront();
            f1.Show();
        }

        private void nhacungcap_Click(object sender, EventArgs e)
        {
            nhacungcapform f1 = new nhacungcapform();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (showform.Controls.Count > 0)
            {
                showform.Controls.Clear();
            }
            showform.Controls.Add(f1);
            f1.BringToFront();
            f1.Show();
        }

        private void phieunhap_Click(object sender, EventArgs e)
        {
            phieunhapform f1 = new phieunhapform();
            f1.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            if (showform.Controls.Count > 0)
            {
                showform.Controls.Clear();
            }
            showform.Controls.Add(f1);
            f1.BringToFront();
            f1.Show();
        }
    }
}
