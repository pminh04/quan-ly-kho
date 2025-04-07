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

namespace quan_ly_kho.View.nhacungcap
{
    public partial class ncc_them : Form
    {
        //Variable
        Model.nhacungcap ncc = new Model.nhacungcap();
        string table_name = "nhacungcap";
        string t_id = "manhacungcap";
        
        public ncc_them()
        {
            InitializeComponent();
        }

        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thembtn_Click(object sender, EventArgs e)
        {
            Model.nhacungcap ncc = new Model.nhacungcap(
                mancc.Text,
                tenncc.Text,
                sdtncc.Text,
                dcncc.Text
            );

            //Console.WriteLine(ncc.Id + "," + ncc.Ten + "," + ncc.Sdt + "," + ncc.Diachi);
            if ( ncc.Id == "" || Controller.DB.checkPK(ncc.Id, table_name,t_id))
            {
                MessageBox.Show("Mã trống hoặc mã bị trùng");
                mancc.Focus();
                return;
            }

            Controller.checkrule cr = new Controller.checkrule();
            if (!cr.checkSdt(ncc.Sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui long nhập lại!");
                sdtncc.Focus();
                return;
            }

            Controller.Them.them_ncc(ncc);
            MessageBox.Show("Thêm mới thành công!");

            this.Close();
            
        }

        private void mancc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
