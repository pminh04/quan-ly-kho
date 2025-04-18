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
using quan_ly_kho.Controller;

namespace quan_ly_kho.View
{
    public partial class log : Form
    {
        //color
        private Color defaultColor = Color.Green;
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
        public log()
        {
            InitializeComponent();
            buttons = new Button[] { close, minimize, dangnhap };

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

            //rounded conners form
            int connerRadius = 10;
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            this.Region = new Region(Rounded_Conners.RoundedConners(bounds, connerRadius,true,true,true,true));




        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

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
    }
}
