using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tu.database;
using tu.model;

namespace tu
{
    public partial class addsanpham : Form
    {
        public addsanpham()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            SanPhamModel sp = new SanPhamModel();

            sp.masanpham = txtmasanpham.Text.Trim();
            sp.tensanpham = txttensanpham.Text.Trim();
            sp.xuatxu = txtxuatxu.Text.Trim();

            // kiểm tra số lượng và đơn giá có hợp lệ không
            if (int.TryParse(txtsoluong.Text.Trim(), out int soluong))
                sp.soluong = soluong;
            else
            {
                MessageBox.Show("Số lượng không hợp lệ");
                return;
            }

            if (decimal.TryParse(txtdongia.Text.Trim(), out decimal dongia))
                sp.dongia = dongia;
            else
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                return;
            }

            sp.trangthai = 1; // mặc định đang tồn tại

            sanphamDAO dao = new sanphamDAO();
            int kq = dao.Insert(sp);

            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                this.DialogResult = DialogResult.OK; // để bên ngoài biết reload
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
