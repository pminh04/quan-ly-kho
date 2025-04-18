﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVatTu;
using quan_ly_kho.Controller;
using quan_ly_kho.View.nhaphang;
using quan_ly_kho.View.phieunhap;
using quan_ly_kho.View.phieuxuat;
using quan_ly_kho.View.sanpham;
using quan_ly_kho.View.thongke;
using quan_ly_kho.View.xuathang;

namespace quan_ly_kho
{
    public partial class mainform : Form
    {
        //button colo
        private Color defaultColor = Color.FromArgb(0, 128, 0);
        private Color activeColor = Color.FromArgb(76, 175, 80);
        private Button[] buttons;

        //drag form
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

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


            //drag form
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;

            //rounded conners
            int connerRadius = 10;
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            this.Region = new Region(Rounded_Conners.RoundedConners(bounds, connerRadius, true, true, true, true));
        }

        //drag form function
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //

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
            chitietphieunhapform f1 = new chitietphieunhapform();
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

        private void nhaphang_Click(object sender, EventArgs e)
        {
            nhaphangform f1 = new nhaphangform();
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

        private void xuathang_Click(object sender, EventArgs e)
        {
            xuathangform f1 = new xuathangform();
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

        private void phieuxuat_Click(object sender, EventArgs e)
        {
            phieuxuatform f1 = new phieuxuatform();
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

        private void thongke_Click(object sender, EventArgs e)
        {
            thongkeform f1 = new thongkeform();
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

        private void taikhoan_Click(object sender, EventArgs e)
        {
            ManagementAccount f1 = new ManagementAccount();
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

        private void khachhang_Click(object sender, EventArgs e)
        {
            ManagementCustomer f1 = new ManagementCustomer();
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

        private void mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
