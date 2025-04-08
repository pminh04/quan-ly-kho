using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using quan_ly_kho.DAO;
using quan_ly_kho.Model;
using quan_ly_kho.View.nhacungcap;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using xls = Microsoft.Office.Interop.Excel;
namespace quan_ly_kho.View.sanpham
{
    public partial class sanphamform : Form
    {
        public sanphamform()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            sanphamDAO dao = new sanphamDAO(); // khởi tạo DAO
            DataTable dt = dao.SelectExist();  // lấy sp có trạng thái = 1

            if (dt != null && dt.Rows.Count > 0)
            {
                tablesanpham.DataSource = dt;
                tablesanpham.Columns["masanpham"].HeaderText = "Mã sản phẩm";
                tablesanpham.Columns["tensanpham"].HeaderText = "Tên sản phẩm";
                tablesanpham.Columns["xuatxu"].HeaderText = "Xuất xứ";
                tablesanpham.Columns["soluong"].HeaderText = "Số lượng";
                tablesanpham.Columns["dongia"].HeaderText = "Đơn giá";
                tablesanpham.Columns["dongia"].DefaultCellStyle.Format = "#,##0.##";

            }
            else
            {
                tablesanpham.DataSource = null;
                MessageBox.Show("Không có dữ liệu.");
            }
        }

        private int selectedIndex = -1;
        private void tablesanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa");
                return;
            }

            string masp = tablesanpham.Rows[selectedIndex].Cells["masanpham"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sanphamDAO dao = new sanphamDAO();
                dao.DeleteTrangThai(masp); // Chuyển trạng thái về 0
                LoadTable(); // Load lại bảng
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa");
                return;
            }

            // Lấy dữ liệu từ dòng được chọn
            string masanpham = tablesanpham.Rows[selectedIndex].Cells["masanpham"].Value.ToString();
            string tensanpham = tablesanpham.Rows[selectedIndex].Cells["tensanpham"].Value.ToString();
            string xuatxu = tablesanpham.Rows[selectedIndex].Cells["xuatxu"].Value.ToString();
            int soluong = int.Parse(tablesanpham.Rows[selectedIndex].Cells["soluong"].Value.ToString());
            decimal dongia = decimal.Parse(tablesanpham.Rows[selectedIndex].Cells["dongia"].Value.ToString());

            // Truyền sang Form sửa (giả sử bạn truyền qua constructor)
            updatesanpham form = new updatesanpham(masanpham, tensanpham, xuatxu, soluong, dongia);
            form.ShowDialog();

            // Sau khi sửa xong load lại bảng
            LoadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addsanpham f1 = new addsanpham();
            f1.BringToFront();
            f1.Show();
            LoadTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                ReadExcel(filename);
                MessageBox.Show("Đã nhập xong từ Excel!");
                // Có thể load lại bảng sản phẩm nếu cần
            }
        }
        public void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel
            xls.Application oExcel = new xls.Application();
            xls.Workbooks oBooks;
            xls.Sheets oSheets;
            xls.Workbook oBook;
            xls.Worksheet oSheet;
            // Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (xls.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (xls.Worksheet)oSheets.get_Item(1);
            oSheet.Name = "Danh sách sản phẩm";

            // Tạo phần đầu
            xls.Range head = oSheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH SẢN PHẨM";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = 18;
            head.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột
            xls.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "MÃ SẢN PHẨM";
            cl1.ColumnWidth = 15;

            xls.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "TÊN SẢN PHẨM";
            cl2.ColumnWidth = 30.0;

            xls.Range cl3 = oSheet.get_Range("D3", "D3");
            cl3.Value2 = "SỐ LƯỢNG";
            cl3.ColumnWidth = 15.0;

            xls.Range cl4 = oSheet.get_Range("E3", "E3");
            cl4.Value2 = "ĐƠN GIÁ";
            cl4.ColumnWidth = 20.0;

            xls.Range cl5 = oSheet.get_Range("C3", "C3");
            cl5.Value2 = "XUẤT XỨ";
            cl5.ColumnWidth = 25.0;

            // Làm đậm tiêu đề
            xls.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = xls.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;

            // Chuyển dữ liệu từ DataTable (tb) vào mảng object
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }

            // Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;

            xls.Range c1 = (xls.Range)oSheet.Cells[rowStart, columnStart];
            xls.Range c2 = (xls.Range)oSheet.Cells[rowEnd, columnEnd];
            xls.Range range = oSheet.get_Range(c1, c2);
            range.Value2 = arr;
            range.Borders.LineStyle = xls.Constants.xlSolid;

            // Căn giữa cột số lượng
            xls.Range slCol = oSheet.get_Range("D4", "D" + rowEnd.ToString());
            slCol.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;

            // Định dạng tiền tệ cho đơn giá
            xls.Range dgCol = oSheet.get_Range("E4", "E" + rowEnd.ToString());
            dgCol.NumberFormat = "#,##0.00";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sanphamDAO dao = new sanphamDAO();
            DataTable dt = dao.SelectExist(); // lấy toàn bộ sản phẩm

            ExportExcel(dt, "DANH SÁCH SẢN PHẨM");
        }
        private void ReadExcel(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Chưa chọn file");
                return;
            }

            xls.Application Excel = new xls.Application();
            xls.Workbook workbook = null;

            try
            {
                workbook = Excel.Workbooks.Open(filename);

                foreach (xls.Worksheet wsheet in workbook.Worksheets)
                {
                    int i = 2; // dòng bắt đầu đọc

                    while (true)
                    {
                        if (wsheet.Cells[i, 1].Value == null && wsheet.Cells[i, 2].Value == null)
                        {
                            break;
                        }

                        try
                        {
                            SanPhamModel sp = new SanPhamModel();
                            sp.masanpham = wsheet.Cells[i, 1].Value?.ToString();
                            sp.tensanpham = wsheet.Cells[i, 2].Value?.ToString();
                            sp.xuatxu = wsheet.Cells[i, 3].Value?.ToString();
                            sp.soluong = int.Parse(wsheet.Cells[i, 4].Value.ToString());
                            sp.dongia = float.Parse(wsheet.Cells[i, 5].Value.ToString());
                            sp.trangthai = 1; // luôn gán mặc định là 1

                            sanphamDAO dao = new sanphamDAO();
                            int result = dao.Insert(sp);
                            if (result == 0)
                            {
                                MessageBox.Show("Không thể thêm dòng " + i + ": " + sp.masanpham);
                            }
                        }
                        catch (Exception exRow)
                        {
                            MessageBox.Show("Lỗi dòng " + i + ": " + exRow.Message);
                        }

                        i++;
                    }
                }

                MessageBox.Show("Đã nhập xong từ Excel!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file Excel: " + ex.Message);
            }
            finally
            {
                if (workbook != null)
                {
                    workbook.Close(false);
                }
                Excel.Quit();
            }
        }

    }
}

    

