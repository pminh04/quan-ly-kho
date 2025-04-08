using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.DAO;
using quan_ly_kho.Model;

namespace quan_ly_kho.View.sanpham
{
    public partial class addsanpham : Form
    {
        public addsanpham()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmasanpham.Text) ||
       string.IsNullOrWhiteSpace(txttensanpham.Text) ||
       string.IsNullOrWhiteSpace(txtxuatxu.Text) ||
       string.IsNullOrWhiteSpace(txtsoluong.Text) ||
       string.IsNullOrWhiteSpace(txtdongia.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Kiểm tra trùng mã sản phẩm
            sanphamDAO dao = new sanphamDAO();
            if (dao.CheckTrungMa(txtmasanpham.Text.Trim()))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.");
                return;
            }

            // Tạo đối tượng sản phẩm
            SanPhamModel sp = new SanPhamModel();
            sp.masanpham = txtmasanpham.Text.Trim();
            sp.tensanpham = txttensanpham.Text.Trim();
            sp.xuatxu = txtxuatxu.Text.Trim();

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

            sp.trangthai = 1;

            int kq = dao.Insert(sp);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void txtmasanpham_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
