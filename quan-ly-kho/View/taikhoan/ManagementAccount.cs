using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.Model;
using quan_ly_kho.DAO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLVatTu
{
    public partial class ManagementAccount : Form
    {
        public void Loaddgv(DataTable dt)
        {
            dgvAccount.DataSource = dt;
        }
        //
        AccountDAO accountDAO = new AccountDAO();
        Account account = new Account();
        public ManagementAccount()
        {
            InitializeComponent();
        }
        

        public void ManagementAccount_Load(object sender, EventArgs e)
        {
            DataTable dataTable = accountDAO.getAllAccount();
            dgvAccount.DataSource = dataTable;
            dgvAccount.Columns[0].Width = 50;
        }

 
        private void ExportToExcel(DataGridView dgv)
        {
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel không được cài đặt trên hệ thống này.");
                return;
            }

            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Name = "ListAccount";

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                }
            }

            excelApp.Visible = true;
            excelApp.UserControl = true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                AddAccountForm f1 = new AddAccountForm(this);
                f1.BringToFront();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị form: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                UpdateAccount updateAccount = new UpdateAccount(this, account);
                updateAccount.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn cập nhập", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvAccount_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                account = new Account();
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                account.hoten = row.Cells[0].Value.ToString();
                account.tendangnhap = row.Cells[1].Value.ToString();
                account.matkhau = row.Cells[2].Value.ToString();
                if (int.TryParse(row.Cells[3].Value?.ToString(), out int trangthai))
                {
                    account.trangthai = trangthai;
                }
                else
                {
                    account.trangthai = 0;
                }
                account.email = row.Cells[4].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (account.tendangnhap != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?",
                                           "Xác nhận xóa",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (accountDAO.deleteAccount(account.tendangnhap))
                    {
                        MessageBox.Show("Account đã được xóa thành công!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagementAccount_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa account này! Vui lòng kiểm tra lại.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvAccount);
        }
    }
}
