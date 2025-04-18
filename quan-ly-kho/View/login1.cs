using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_kho.View
{
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform f1 = new mainform();
            f1.BringToFront();
            f1.Show();
            this.Hide();
        }
    }
}
