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
    public partial class UpdateAccount : Form
    {
        ManagementAccount managementAccount = new ManagementAccount();
        private Account account;
        AccountDAO accountDAO = new AccountDAO();

        public UpdateAccount(ManagementAccount managementAccount, Account account)
        {
            InitializeComponent();
            this.managementAccount = managementAccount;
            this.account = account;
        }

        private void UpdateAccount_Load(object sender, EventArgs e)
        {
            txtTentaikhoan.Text = account.hoten;
            txtTenDN.Text = account.tendangnhap;
            txtEmail.Text = account.email;
            cboTrangthai.SelectedIndex = account.trangthai;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            string hoten = txtTentaikhoan.Text.Trim();
            string tendangnhap = txtTenDN.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matkhau = txtPasword.Text.Trim();
            string vaitro = txtVaitro.Text.Trim();


            if (string.IsNullOrWhiteSpace(hoten))
            {
                MessageBox.Show("Tên tài khoản được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTentaikhoan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tendangnhap))
            {
                MessageBox.Show("Tên đăng nhập không được để trống hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txtPasword.Focus();
                return;
            }

            int trangthai = cboTrangthai.SelectedIndex;

            string hashedPassword = SecurityHelper.HashPassword(matkhau);
            Account account = new Account(hoten, tendangnhap, hashedPassword, trangthai, email, vaitro);

            if (accountDAO.updateAccount(account))
            {
                MessageBox.Show("Tài khoản đã được cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                managementAccount.ManagementAccount_Load(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
