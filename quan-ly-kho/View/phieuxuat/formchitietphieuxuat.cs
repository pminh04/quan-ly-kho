using System.Net.NetworkInformation;
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
using static quan_ly_kho.Model.chitietphieuxuat_model;
using xls = Microsoft.Office.Interop.Excel;
namespace quan_ly_kho.View.phieuxuat
{
    public partial class chitietphieuxuatform : Form
    {
        public void Loaddgv(DataTable dt)
        {
            tablechitietphieuxuat.DataSource = dt;
        }
        public chitietphieuxuatform()
        {
            InitializeComponent();
            LoadTable();
        }
        private int selectedIndex = -1;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadTable()
        {
            phieuxuatDAO dao = new phieuxuatDAO(); // khởi tạo DAO
            DataTable dt = dao.SelectAll();  // lấy sp có trạng thái = 1

            if (dt != null && dt.Rows.Count > 0)
            {
                tablechitietphieuxuat.DataSource = dt;
                tablechitietphieuxuat.Columns["maphieu"].HeaderText = "Mã phiếu xuất";
                tablechitietphieuxuat.Columns["thoigiantao"].HeaderText = "Thời gian tạo";
                tablechitietphieuxuat.Columns["nguoitao"].HeaderText = "Người tạo";
                tablechitietphieuxuat.Columns["makhachhang"].HeaderText = "Mã khách hàng";
                tablechitietphieuxuat.Columns["tongtien"].HeaderText = "Tổng tiền";
                tablechitietphieuxuat.Columns["tongtien"].DefaultCellStyle.Format = "#,##0.##";

            }
            else
            {
                tablechitietphieuxuat.DataSource = null;
                MessageBox.Show("Không có dữ liệu.");
            }
        }

        private void tablechitietphieuxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string selectedMaphieu = "";
       
        private void tablechitietphieuxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã phiếu từ cột "maphieu" trong dòng được chọn
                selectedMaphieu = tablechitietphieuxuat.Rows[e.RowIndex].Cells["maphieu"].Value.ToString();
            }
        }
        public void ExportPhieuXuat(DataTable tb, string sheetname)
        {
            xls.Application oExcel = new xls.Application();
            xls.Workbooks oBooks;
            xls.Sheets oSheets;
            xls.Workbook oBook;
            xls.Worksheet oSheet;

            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (xls.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (xls.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;

            // Phần đầu
            xls.Range head = oSheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH PHIẾU XUẤT";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = 18;
            head.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;

            // Tiêu đề cột
            oSheet.Cells[3, 1] = "MÃ PHIẾU XUẤT";
            oSheet.Cells[3, 2] = "THỜI GIAN TẠO";
            oSheet.Cells[3, 3] = "NGƯỜI TẠO";
            oSheet.Cells[3, 4] = "KHÁCH HÀNG";
            oSheet.Cells[3, 5] = "TỔNG TIỀN";

            xls.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = xls.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = xls.XlHAlign.xlHAlignCenter;
            rowHead.ColumnWidth = 20;

            // Ghi dữ liệu
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

            // Format ngày
            xls.Range dateCol = oSheet.get_Range("B4", "B" + rowEnd);
            dateCol.NumberFormat = "dd/MM/yyyy HH:mm";

            // Format tổng tiền
            xls.Range moneyCol = oSheet.get_Range("E4", "E" + rowEnd);
            moneyCol.NumberFormat = "#,##0.##";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tablechitietphieuxuat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu xuất để sửa.");
                return;
            }

            DataGridViewRow selectedRow = tablechitietphieuxuat.SelectedRows[0];

            string maphieu = selectedRow.Cells["maphieu"].Value.ToString();
            formsuachitietphieuxuat frm = new formsuachitietphieuxuat(maphieu);

            // Truyền mã phiếu qua form sửa
            frm.ShowDialog();
        }

        private void formchitietphieuxuat_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tablechitietphieuxuat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu xuất để xóa.");
                return;
            }

            // Lấy mã phiếu xuất từ dòng đã chọn
            DataGridViewRow selectedRow = tablechitietphieuxuat.SelectedRows[0];
            string maphieu = selectedRow.Cells["maphieu"].Value.ToString();

            // Xác nhận xóa
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu xuất này?", "Xóa phiếu xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xóa phiếu xuất khỏi cơ sở dữ liệu
                phieuxuatDAO dao = new phieuxuatDAO();
                int isDeleted = dao.Delete(maphieu);

                if (isDeleted > 0)
                {
                    // Xóa dòng khỏi DataGridView
                    tablechitietphieuxuat.Rows.RemoveAt(selectedRow.Index);
                    MessageBox.Show("Xóa phiếu xuất thành công.");
                }
                else
                {
                    MessageBox.Show("Xóa phiếu xuất thất bại.");
                }
            }
        }

        private void btnxemchitiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaphieu))
            {
                MessageBox.Show("Vui lòng chọn một phiếu xuất để xem chi tiết.");
                return;
            }

            // Lấy chi tiết phiếu xuất theo mã phiếu đã chọn
            chitietphieuxuatDAO dao = new chitietphieuxuatDAO();
            DataTable dt = dao.SelectByMaphieu(selectedMaphieu);  // Truy vấn theo mã phiếu

            // Kiểm tra nếu có dữ liệu và hiển thị
            if (dt != null && dt.Rows.Count > 0)
            {
                formxemchitietphieuxuat frm = new formxemchitietphieuxuat();
                frm.LoadData(dt);  // Truyền dữ liệu chi tiết vào form
                frm.ShowDialog();   // Hiển thị form xem chi tiết
            }
            else
            {
                MessageBox.Show("Không có dữ liệu chi tiết cho mã phiếu này.");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            float giaTu = 0;
            float giaDen = float.MaxValue;

            // Kiểm tra và parse giá trị
            if (!string.IsNullOrEmpty(txtGiaTu.Text))
            {
                float.TryParse(txtGiaTu.Text, out giaTu);
            }

            if (!string.IsNullOrEmpty(txtGiaDen.Text))
            {
                float.TryParse(txtGiaDen.Text, out giaDen);
            }

            phieuxuatDAO dao = new phieuxuatDAO();
            DataTable dt = dao.SelectByGia(giaTu, giaDen);

            if (dt != null && dt.Rows.Count > 0)
            {
                tablechitietphieuxuat.DataSource = dt;
            }
            else
            {
                tablechitietphieuxuat.DataSource = null;
                MessageBox.Show("Không tìm thấy phiếu xuất trong khoảng giá.");
            }
        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)tablechitietphieuxuat.DataSource;
            ExportPhieuXuat(dt, "PHIẾU XUẤT");
        }
    }
}
