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
using quan_ly_kho.Model;

namespace QLVatTu
{
    public partial class AddAccountForm : Form
    {
        ManagementAccount managementAccount;
        AccountDAO accountDAO = new AccountDAO();
        public AddAccountForm(ManagementAccount managementAccount)
        {
            InitializeComponent();
            this.managementAccount = managementAccount;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoten = txtTenTK.Text.Trim();
            string tendangnhap = txtTenDN.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matkhau = txtMatkhau.Text.Trim();


           
            if (string.IsNullOrWhiteSpace(hoten))
            {
                MessageBox.Show("Tên tài khoản được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTK.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tendangnhap))
            {
                MessageBox.Show("Tên đăngn nhập không được để trống hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Password không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatkhau.Focus();
                return;
            }

            if (accountDAO.checkUsernameExists(tendangnhap))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDN.Focus();
                return;
            }

            string hashedPassword = SecurityHelper.HashPassword(matkhau);
            Account account = new Account(hoten, tendangnhap, hashedPassword, 0, email);

            if (accountDAO.insertAccount(account))
            {
                MessageBox.Show("Tài khoản đã được thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                managementAccount.ManagementAccount_Load(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnHuy_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtMatkhau.Text = string.Empty;
            txtTenDN.Text = string.Empty;
            txtTenTK.Text = string.Empty;   
        }
    }
}
