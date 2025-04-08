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

namespace quan_ly_kho
{
    public partial class UpdateCustomer : Form
    {
        ManagementCustomer managementCustomer = new ManagementCustomer();
        private Customer customer;
        KhachHangDAO khachHangDAO = new KhachHangDAO();
        public UpdateCustomer(ManagementCustomer management, Customer customer)
        {
            InitializeComponent();
            this.managementCustomer = management;
            this.customer = customer;
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            txtID.Text = customer.id;
            txtDiachi.Text = customer.diachi;
            txtEmail.Text = customer.email; 
            txtSDT.Text = customer.sdt;
            txtTen.Text = customer.hoten;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string ten = txtTen.Text.Trim();
            string soDT = txtSDT.Text.Trim();
            string diaChi = txtDiachi.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Mã khách hàng không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(soDT) || !IsValidPhoneNumber(soDT))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(diaChi))
            {
                MessageBox.Show("Địa chỉ không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            Customer customer = new Customer(id, ten, email, soDT, diaChi);

            if (khachHangDAO.updateKhachHang(customer))
            {
                MessageBox.Show("Khách hàng đã được cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                managementCustomer.ManagementCustomer_Load(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10,15}$");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiachi.Text = "";
        }
    }
}
