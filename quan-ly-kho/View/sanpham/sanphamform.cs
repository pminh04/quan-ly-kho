using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using quan_ly_kho.Controller;

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
        public void Loaddgv(DataTable dt)
        {
            tablesanpham.DataSource = dt;
        }
        public sanphamform()
        {
            InitializeComponent();
          
        }
        string table_name = "sanpham";
      
        

        private int selectedIndex = -1;
        private String selectedma;
        private String selectedten;
        private String selectedxuatxu;
        private String selectedmaloai;
        private String selectedtenloai;
        private int selectedsoluong;
        private void tablesanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 ) // Đảm bảo chỉ xử lý khi có hàng được chọn
            {
                  selectedma = tablesanpham.Rows[i].Cells["masanpham"].Value.ToString();
                  selectedten = tablesanpham.Rows[i].Cells["tensanpham"].Value.ToString();
                  selectedxuatxu = tablesanpham.Rows[i].Cells["xuatxu"].Value.ToString();
                  selectedmaloai = tablesanpham.Rows[i].Cells["maloaihang"].Value.ToString();
                  selectedtenloai = tablesanpham.Rows[i].Cells["tenloaihang"].Value.ToString();
                  selectedsoluong = (int)tablesanpham.Rows[i].Cells["soluong"].Value;

            }
        }
      
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (selectedma == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa.");
                return;
            }
       
            DialogResult result = MessageBox.Show("Có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Controller.Xoa.xoa_sp(selectedma);
                MessageBox.Show("Xóa thành công!");

                loaddata.show_sp(tablesanpham, table_name);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Model.SanPhamModel sp = new Model.SanPhamModel(selectedma, selectedten, selectedxuatxu, selectedmaloai, selectedsoluong);
            if (selectedma == null)
            {
                MessageBox.Show("Vui long chọn dữ liệu cần sửa.");
                return;
            }
            updatesanpham f1 = new updatesanpham(sp);
            f1.BringToFront();
            f1.Show();
            f1.FormClosed += (obj, args) =>
            {
                loaddata.show_sp(tablesanpham, table_name);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addsanpham f1 = new addsanpham();
            f1.BringToFront();
            f1.Show();
            f1.FormClosed += (obj, args) =>
            {
                loaddata.show_sp(tablesanpham, table_name);
            };
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sanphamform_Load(object sender, EventArgs e)
        {
            loaddata.show_sp(tablesanpham, table_name);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tablesanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            string sql = "SELECT masanpham, tensanpham, xuatxu, lh.tenloaihang, soluong FROM sanpham join loaihang lh on lh.maloaihang = sanpham.maloaihang";

            // Gọi hàm get_data() để lấy dữ liệu vào DataTable
            DataTable dt = DB.get_data(sql);

            // Các tiêu đề cột bạn muốn xuất Excel
            string[] titles = { "Mã SP", "Tên SP", "Xuất xứ", "Loại hàng", "Số lượng" };

            // Gọi hàm ExportToExcel để xuất dữ liệu
            excel ex = new excel();
            ex.ExportToExcel(dt, "Danh Sách Sản Phẩm", titles);
        }

        private void btnnhapexcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog { Filter = "Excel Files|*.xls;*.xlsx", Multiselect = false };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Mảng tên cột tương ứng với bảng CSDL
                string[] columnNames = { "masanpham", "tensanpham", "xuatxu", "maloaihang", "soluong" };

                // Tạo đối tượng của ExcelController từ Controller
               excel excelController = new excel();

                // Gọi hàm ReadExcel trong Controller để xử lý dữ liệu từ Excel
                excelController.ReadExcel(dlg.FileName, "sanpham", columnNames);
            }

            loaddata.show_sp(tablesanpham, table_name);
            
        }
    }
}

    

