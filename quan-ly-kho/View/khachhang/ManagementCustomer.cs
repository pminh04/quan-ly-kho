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
using Excel = Microsoft.Office.Interop.Excel;

namespace quan_ly_kho
{
    public partial class ManagementCustomer : Form
    {

        KhachHangDAO khachHang = new KhachHangDAO();
        Customer customer;

        public ManagementCustomer()
        {
            InitializeComponent();
        }

        public void ManagementCustomer_Load(object sender, EventArgs e)
        {
            DataTable dataTable = khachHang.getAllKhachHang();
            dgvCustomer.DataSource = dataTable;
            dgvCustomer.Columns[0].Width = 50;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                customer = new Customer();
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                customer.id = row.Cells[0].Value.ToString(); 
                customer.hoten = row.Cells[1].Value.ToString();
                customer.email = row.Cells[2].Value.ToString();
                customer.sdt = row.Cells[3].Value.ToString();
                customer.diachi = row.Cells[4].Value.ToString();
            }
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
            worksheet.Name = "ListCustomer";

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(this);
            addCustomer.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                UpdateCustomer updateCustomer = new UpdateCustomer(this, customer);
                updateCustomer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng muốn cập nhật", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customer.id != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?",
                                           "Xác nhận xóa",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (khachHang.deleteKhachHang(customer.id))
                    {
                        MessageBox.Show("Khách hàng đã được xóa thành công!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ManagementCustomer_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách hàng này! Vui lòng kiểm tra lại.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvCustomer);
        }
    }
}
