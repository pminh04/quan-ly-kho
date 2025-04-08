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
using quan_ly_kho.DAO;

namespace quan_ly_kho.View.phieuxuat
{
    public partial class phieuxuatform: Form
    {
        public phieuxuatform()
        {
            InitializeComponent();
            LoadTable();

        }

        private void LoadTable()
        {
            loaddata.show_px(tabctpx);

        }

        private void importexcelbtn_Click(object sender, EventArgs e)
        {

        }

        private void suabtn_Click(object sender, EventArgs e)
        {

        }

        private void toolbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
