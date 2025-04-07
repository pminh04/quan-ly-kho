using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_kho.View.nhacungcap
{
    public partial class ncc_sua : Form
    {
        private Model.nhacungcap ncc;
        public ncc_sua(Model.nhacungcap ncc)
        {
            InitializeComponent();
            this.ncc=ncc;
            
        }
        private void ncc_sua_Load(object sender, EventArgs e)
        {
            mancc.Text = ncc.Id;
            tenncc.Text = ncc.Ten;
            sdtncc.Text = ncc.Sdt;
            dcncc.Text = ncc.Diachi;
        }

        private void huybtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capnhatbtn_Click(object sender, EventArgs e)
        {
            Model.nhacungcap ncc = new Model.nhacungcap(
                mancc.Text,
                tenncc.Text,
                sdtncc.Text,
                dcncc.Text
                );


            Controller.checkrule cr = new Controller.checkrule();
            if (!cr.checkSdt(ncc.Sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui long nhập lại!");
                sdtncc.Focus();
                return;
            }

            Controller.Sua.sua_ncc(ncc);

            MessageBox.Show("Cập nhật thành công!");
            this.Close() ;
        }

        
    }
}
