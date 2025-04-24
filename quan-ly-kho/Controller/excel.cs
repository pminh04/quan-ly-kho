using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using xls = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
namespace quan_ly_kho.Controller
{
    public class excel
    {
        public void ExportToExcel(DataTable tb, string sheetName, string[] columnTitles)
        {
            xls.Application oExcel = new xls.Application();
            xls.Workbook oBook = oExcel.Workbooks.Add(Type.Missing);
            xls.Worksheet oSheet = (xls.Worksheet)oBook.Worksheets[1];
            oSheet.Name = sheetName;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;

            // Tiêu đề bảng
            xls.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = $"DANH SÁCH {sheetName.ToUpper()}";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = 18;
            head.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;
            head.Borders.LineStyle = xls.Constants.xlSolid;

            // Tiêu đề cột
            int columnIndex = 1;
            for (int i = 0; i < columnTitles.Length; i++)
            {
                oSheet.Cells[3, columnIndex] = columnTitles[i];
                columnIndex++;
            }

            // Định dạng tiêu đề cột
            xls.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = xls.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 15;  // Màu nền
            rowHead.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;
            rowHead.ColumnWidth = 20;

            // Ghi dữ liệu từ DataTable
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                for (int c = 0; c < tb.Columns.Count; c++)
                {
                    arr[r, c] = tb.Rows[r][c];
                }
            }

            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;

            xls.Range c1 = (xls.Range)oSheet.Cells[rowStart, columnStart];
            xls.Range c2 = (xls.Range)oSheet.Cells[rowEnd, columnEnd];
            xls.Range range = oSheet.get_Range(c1, c2);
            range.Value2 = arr;
            range.Borders.LineStyle = xls.Constants.xlSolid;

            // Định dạng ngày nếu có cột "ThoiGianTao"
            if (tb.Columns.Contains("ThoiGianTao"))
            {
                xls.Range dateCol = oSheet.get_Range("B4", "B" + rowEnd);
                dateCol.NumberFormat = "dd/MM/yyyy HH:mm";
            }


            for (int i = 1; i <= tb.Columns.Count; i++)
            {
                oSheet.Columns[i].AutoFit();
            }


        }
        public void ReadExcel(string filename, string tableName, string[] columnNames)
        {
            if (filename == null)
            {
                MessageBox.Show("Chưa chọn file");
                return;
            }

            xls.Application Excel = new xls.Application();
            Excel.Workbooks.Open(filename);

            foreach (xls.Worksheet wsheet in Excel.Worksheets)
            {
                int i = 4;  // Bắt đầu từ dòng 4 (giả sử dữ liệu bắt đầu từ dòng này)
                while (wsheet.Cells[i, 1].Value != null)
                {
                    string sql = $"INSERT INTO {tableName} ({string.Join(", ", columnNames)}) VALUES (";

                    for (int j = 0; j < columnNames.Length; j++)
                    {
                        string cellValue = wsheet.Cells[i, j + 1].Value?.ToString() ?? "";

                        // Kiểm tra và xử lý ngày tháng
                        if (DateTime.TryParse(cellValue, out DateTime dateValue))
                            cellValue = dateValue.ToString("yyyy-MM-dd");

                        // Xử lý dấu nháy đơn trong chuỗi
                        sql += $"N'{cellValue.Replace("'", "''")}', ";
                    }

                    sql = sql.TrimEnd(',', ' ') + ")";  // Cắt dấu phẩy cuối cùng và thêm dấu đóng ngoặc
                    DB.insert(sql);  // Gọi hàm insert trong DB để thực thi SQL
                    i++;  // Chuyển sang dòng tiếp theo
                }
            }

            Excel.Quit();  // Đảm bảo đóng Excel sau khi xử lý xong
        }

    }
}
