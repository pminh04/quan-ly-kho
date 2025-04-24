using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.Controller;
using quan_ly_kho.DAO;
using quan_ly_kho.Model;

namespace quan_ly_kho.View.sanpham
{
    public partial class addsanpham : Form
    {
        string table_name = "sanpham";
        string t_id = "masanpham";

        public addsanpham()
        {
            InitializeComponent();
            
        }
        public void loadTenloaihang()
        {
            string sql = "SELECT maloaihang, tenloaihang FROM loaihang";
            DB.loadcbox(cbxloaihang, sql, "tenloaihang","maloaihang");
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string masp = txtmasanpham.Text.Trim();
            string tensp = txttensanpham.Text.Trim();
            string xuatxu = txtxuatxu.Text.Trim();
            string maloai = cbxloaihang.SelectedValue.ToString();
            //string dongiaText = txtdongia.Text.Trim();
            //decimal dongia;
            //bool isDecimal = decimal.TryParse(dongiaText, out dongia);
            //if (!isDecimal || dongia < 0)
            //{
            //    MessageBox.Show("Đơn giá không hợp lệ, vui lòng nhập số dương!");
            //    return;
            //}
            
            // Tạo đối tượng sản phẩm với số lượng mặc định là 0
            Model.SanPhamModel sp = new Model.SanPhamModel(
                masp,
                tensp,
                xuatxu,
                maloai,
                0
 );
            if (masp == "" || tensp == "" || xuatxu == "")
            {
                MessageBox.Show("Không được để trống !");
                return;
            }
            else if (cbxloaihang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại hàng");
                return;
            }
            else if (Controller.DB.checkPK(sp.masanpham, table_name, t_id))
            {
                MessageBox.Show("Mã bị trùng");
                txtmasanpham.Focus();
                return;
            }
            // Gọi DAO để thêm sản phẩm
            Controller.Them.them_sp(sp);
            MessageBox.Show("Thêm mới thành công!");

            this.Close();
           
            
        }

        private void txtmasanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void addsanpham_Load(object sender, EventArgs e)
        {
            loadTenloaihang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}
