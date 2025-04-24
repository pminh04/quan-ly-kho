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
using quan_ly_kho.View.nhacungcap;

namespace quan_ly_kho
{
    public partial class nhacungcapform : Form
    {
        string table_name = "nhacungcap";
        public void Loaddgv(DataTable dt)
        {
            ncctb.DataSource = dt;
        }
        public nhacungcapform()
        {
            InitializeComponent();
        }


        private void themmoibtn_Click(object sender, EventArgs e)
        {
            ncc_them f1 = new ncc_them();
            f1.BringToFront();
            f1.Show();
            f1.FormClosed += (obj, args) =>
            {
                loaddata.show_ncc(ncctb, table_name);
            };

        }

        private void nhacungcap_Load(object sender, EventArgs e)
        {
            loaddata.show_ncc(ncctb, table_name);
        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa.");
                return;
            }
            Model.nhacungcap ncc = new Model.nhacungcap(selectedId);
            DialogResult result = MessageBox.Show("Có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Controller.Xoa.xoa_ncc(ncc);
                MessageBox.Show("Xóa thành công!");

                loaddata.show_ncc(ncctb, table_name);
            }
        }

        private string selectedId;
        private string selectedTen;
        private string selectedSdt;
        private string selectedDiachi;
        private void ncctb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0 && !ncctb.Rows[i].IsNewRow)
            {
                selectedId = ncctb.Rows[e.RowIndex].Cells["id"].Value.ToString();
                selectedTen = ncctb.Rows[e.RowIndex].Cells["ten"].Value.ToString();
                selectedSdt = ncctb.Rows[e.RowIndex].Cells["sdt"].Value.ToString();
                selectedDiachi = ncctb.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
            }
        }

        private void suabtn_Click(object sender, EventArgs e)
        {
            
            Model.nhacungcap ncc = new Model.nhacungcap(selectedId,selectedTen,selectedSdt,selectedDiachi);
            if(selectedId == null) 
            { 
                MessageBox.Show("Vui long chọn dữ liệu cần sửa.");
                return;
            }
            ncc_sua f1 = new ncc_sua(ncc);
            f1.BringToFront();
            f1.Show();
            f1.FormClosed += (obj, args) =>
            {
                loaddata.show_ncc(ncctb, table_name);
            };
        }

        private void exportexcelbtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM nhacungcap";

            // Gọi hàm get_data() để lấy dữ liệu vào DataTable
            DataTable dt = DB.get_data(sql);

            // Các tiêu đề cột bạn muốn xuất Excel
            string[] titles = { "Mã nhà cung cấp", "Tên nhà cung cấp", "Số điện thoại", "Địa chỉ"};

            // Gọi hàm ExportToExcel để xuất dữ liệu
            excel ex = new excel();
            ex.ExportToExcel(dt, "Danh Sách Nhà Cung Cấp", titles);
        }

        private void importexcelbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog { Filter = "Excel Files|*.xls;*.xlsx", Multiselect = false };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Mảng tên cột tương ứng với bảng CSDL
                string[] columnNames = { "manhacungcap", "tennhacungcap", "sdt", "diachi"};

                // Tạo đối tượng của ExcelController từ Controller
                excel excelController = new excel();

                // Gọi hàm ReadExcel trong Controller để xử lý dữ liệu từ Excel
                excelController.ReadExcel(dlg.FileName, "nhacungcap", columnNames);
            }

            loaddata.show_sp(ncctb, table_name);
        }
    }
}
