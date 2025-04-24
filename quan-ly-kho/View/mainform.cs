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
using QLVatTu;
using quan_ly_kho.Controller;
using quan_ly_kho.Model;
using quan_ly_kho.View;
using quan_ly_kho.View.nhaphang;
using quan_ly_kho.View.phieunhap;
using quan_ly_kho.View.phieuxuat;
using quan_ly_kho.View.sanpham;
using quan_ly_kho.View.thongke;
using quan_ly_kho.View.xuathang;
using static System.Net.Mime.MediaTypeNames;
using static quan_ly_kho.Model.chitietphieunhap;

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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Items.AddRange(new string[] { "--Chọn--", "Mã sản phẩm", "Tên sản phẩm", "Xuất xứ", "Loại hàng" });
            timkiemcbx.SelectedIndex = 0;
            timkiemcbx.Visible = true;
            timkiemtext.Visible = true;
            timkiembtn.Visible = true;
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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Items.AddRange(new string[] { "--Chọn--", "Mã nhà cung cấp", "Tên nhà cung cấp", "Số điện thoại", "Địa chỉ" });
            timkiemcbx.SelectedIndex = 0;
            timkiemcbx.Visible = true;
            timkiemtext.Visible = true;
            timkiembtn.Visible = true;
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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Items.AddRange(new string[] { "--Chọn--", "Mã phiếu", "Thời gian tạo", "Người tạo", "Mã nhà cung cấp"});
            timkiemcbx.SelectedIndex = 0;
            timkiemcbx.Visible = true;
            timkiemtext.Visible = true;
            timkiembtn.Visible = true;



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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Items.AddRange(new string[] { "--Chọn--", "Mã sản phẩm" });
            timkiemcbx.SelectedIndex = 0;
            timkiemcbx.Visible = true;
            timkiemtext.Visible = true;
            timkiembtn.Visible = true;

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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Items.AddRange(new string[] { "--Chọn--", "Mã sản phẩm" });
            timkiemcbx.SelectedIndex = 0;
            timkiemcbx.Visible = true;
            timkiemtext.Visible = true;
            timkiembtn.Visible = true;

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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Items.AddRange(new string[] { "--Chọn--", "Mã phiếu", "Thời gian tạo", "Người tạo", "Mã khách hàng"});
            timkiemcbx.SelectedIndex = 0;
            timkiemcbx.Visible = true;
            timkiemtext.Visible = true;
            timkiembtn.Visible = true;

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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Visible = false;
            timkiemtext.Visible = false;
            timkiembtn.Visible = false;

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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Items.AddRange(new string[] { "--Chọn--","Họ tên", "Tên người dùng", "Vai trò", "Email" });
            timkiemcbx.SelectedIndex = 0;
            timkiemcbx.Visible = true;
            timkiemtext.Visible = true;
            timkiembtn.Visible = true;
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
            
            //
            timkiemcbx.Items.Clear();
            timkiemcbx.Items.AddRange(new string[] { "--Chọn--", "Mã khách hàng", "Tên khách hàng", "Email", "Số điện thoại", "Địa chỉ" });
            timkiemcbx.SelectedIndex = 0;
            timkiemcbx.Visible = true;
            timkiemtext.Visible = true;
            timkiembtn.Visible = true;
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
            System.Windows.Forms.Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                log logform = new log();
                logform.Show();
            }
        }



        private void timkiembtn_Click(object sender, EventArgs e)
        {
            if (showform.Controls.Count > 0)
            {
                Control currentControl = showform.Controls[0];

                if (currentControl is sanphamform spform)
                {
                    SanPhamModel sp = new SanPhamModel(
                        timkiemcbx.Text,
                        timkiemtext.Text
                        );
                    DataTable dt = timkiem.timkiemsp(sp);
                    spform.Loaddgv(dt);
                }
                else if (currentControl is nhacungcapform nccform)
                {
                    nhacungcapmodel ncc = new nhacungcapmodel(
                        timkiemcbx.Text,
                        timkiemtext.Text
                        );
                    DataTable dt = timkiem.timkiemncc(ncc);
                    nccform.Loaddgv(dt);
                }
                else if (currentControl is ManagementCustomer khform)
                {
                    Customer kh = new Customer(
                        timkiemcbx.Text,
                        timkiemtext.Text
                        );
                    DataTable dt = timkiem.timkiemkh(kh);
                    khform.Loaddgv(dt);
                }
                else if (currentControl is chitietphieunhapform ctpnform)
                {
                    string datePicker = datepicker.Value.ToString("yyyy-MM-dd");

                    chitietphieunhap.chitietphieunhapmodel ctpn = new chitietphieunhap.chitietphieunhapmodel(
                        timkiemcbx.Text,
                        timkiemtext.Text,
                        datePicker
                        );
                    
                    DataTable dt = timkiem.timkiemctpn(ctpn);
                    ctpnform.Loaddgv(dt);

                    if (timkiemcbx.Text == "Thời gian tạo")
                    {
                        timkiemtext.Visible = false;
                        datepicker.Visible = true;
                    }
                }
                else if (currentControl is nhaphangform nhform)
                {
                    phieunhapmodel pn = new phieunhapmodel(
                        timkiemcbx.Text,
                        timkiemtext.Text
                        );
                    DataTable dt = timkiem.timkiempn(pn);
                    nhform.Loaddgv(dt);
                }
                else if (currentControl is xuathangform xhform)
                {
                    phieuxuatmodel px = new phieuxuatmodel(
                        timkiemcbx.Text,
                        timkiemtext.Text
                        );
                    DataTable dt = timkiem.timkiempx(px);
                    xhform.Loaddgv(dt);
                }
                else if (currentControl is phieuxuatform ctpxform)
                {
                    string datePicker = datepicker.Value.ToString("yyyy-MM-dd");

                    chitietphieuxuatmodel ctpx = new chitietphieuxuatmodel(
                        timkiemcbx.Text,
                        timkiemtext.Text,
                        datePicker
                        );

                    DataTable dt = timkiem.timkiemctpx(ctpx);
                    ctpxform.Loaddgv(dt);

                    if (timkiemcbx.Text == "Thời gian tạo")
                    {
                        timkiemtext.Visible = false;
                        datepicker.Visible = true;
                    }
                }
                else if (currentControl is ManagementAccount tkform)
                {
                    Account tk = new Account(
                        timkiemcbx.Text,
                        timkiemtext.Text
                        );
                    DataTable dt = timkiem.timkiemtk(tk);
                    tkform.Loaddgv(dt);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chức năng thích hợp.");
                    timkiemcbx.Items.Clear();
                }
            }
        }

        private void timkiemcbx_TextChanged(object sender, EventArgs e)
        {
            if (timkiemcbx.Text == "Thời gian tạo")
            {
                timkiemtext.Visible = false;
                datepicker.Visible = true;
            }
        }
    }
}
