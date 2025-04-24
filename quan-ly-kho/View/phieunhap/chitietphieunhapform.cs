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
using static quan_ly_kho.Model.chitietphieunhap;
using xls = Microsoft.Office.Interop.Excel;
using quan_ly_kho.Controller;
using quan_ly_kho.View.sanpham;
namespace quan_ly_kho.View.phieunhap
{
    public partial class chitietphieunhapform : Form
    {
        String table_name = "phieunhap";
        public void Loaddgv(DataTable dt)
        {
            tablechitietphieunhap.DataSource = dt;
        }
        public chitietphieunhapform()
        {
            InitializeComponent();
            
        }
        private int selectedIndex = -1;
        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void tablechitietphieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private String selectedmaphieu;
        private DateTime selectedtime;
        private String selectedngtao;
        private String selectedmanhacungcap;
        private double selectedtongtien;
        private void tablechitietphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i= e.RowIndex;
            if (i >= 0)
            {
                // Lấy mã phiếu từ cột "maphieu" trong dòng được chọn
                selectedmaphieu = tablechitietphieunhap.Rows[i].Cells["maphieu"].Value.ToString();
                selectedtime= Convert.ToDateTime(tablechitietphieunhap.Rows[i].Cells["thoigiantao"].Value);
                selectedngtao = tablechitietphieunhap.Rows[i].Cells["nguoitao"].Value.ToString();
                selectedmanhacungcap = tablechitietphieunhap.Rows[i].Cells["manhacungcap"].Value.ToString();
                selectedtongtien = Convert.ToSingle(tablechitietphieunhap.Rows[i].Cells["tongtien"].Value);

            }
        }
      

        private void btnsua_Click(object sender, EventArgs e)
        {
            Model.phieunhapmodel pn = new Model.phieunhapmodel(selectedmaphieu, selectedtime, selectedngtao, selectedmanhacungcap, selectedtongtien);
            Console.WriteLine("maphieu: " + selectedmaphieu);
            Console.WriteLine("ngtao: " + selectedngtao);
            Console.WriteLine("nhacungcap: " + selectedmanhacungcap);
            Console.WriteLine("thoigian: " + selectedtime);
            Console.WriteLine("tongtien: " + selectedtongtien);


            if (selectedmaphieu == null)
            {
                MessageBox.Show("Vui long chọn dữ liệu cần sửa.");
                return;
            }
            formsuachitietphieunhap f1 = new formsuachitietphieunhap(pn);
            f1.BringToFront();
            f1.Show();
            f1.FormClosed += (obj, args) =>
            {
                loaddata.show_pn(tablechitietphieunhap, table_name);
            };
        }

        private void chitietphieunhapform_Load(object sender, EventArgs e)
        {
            loaddata.show_pn(tablechitietphieunhap, table_name);
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (selectedmaphieu == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Controller.Xoa.xoa_pn(selectedmaphieu);
                Controller.Xoa.xoa_ctpn(selectedmaphieu);
                MessageBox.Show("Xóa thành công!");

                loaddata.show_pn(tablechitietphieunhap, table_name);
            }
        }
        

        private void btnxemchitiet_Click(object sender, EventArgs e)
        {
            if (selectedmaphieu == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xóa.");
                return;
            }
            formxemchitietphieunhap f1 = new formxemchitietphieunhap(selectedmaphieu);
            f1.BringToFront();
            f1.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            float giaTu = 0;
            float giaDen = float.MaxValue;

            // Parse giá trị nếu có nhập
            if (!string.IsNullOrEmpty(txtGiaTu.Text))
            {
                float.TryParse(txtGiaTu.Text, out giaTu);
            }

            if (!string.IsNullOrEmpty(txtGiaDen.Text))
            {
                float.TryParse(txtGiaDen.Text, out giaDen);
            }

            // Gọi hàm lọc
            DataTable dt = Controller.DB.SelectByGia("phieunhap", giaTu, giaDen);

            // Hiển thị lên bảng phiếu nhập
            if (dt != null && dt.Rows.Count > 0)
            {
                tablechitietphieunhap.DataSource = dt;
            }
            else
            {
                tablechitietphieunhap.DataSource = null;
                MessageBox.Show("Không tìm thấy phiếu nhập trong khoảng giá.");
            }

        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            string sql = "SELECT mp.maphieu, mp.thoigiantao, mp.nguoitao, ncc.tennhacungcap, mp.tongtien FROM phieunhap mp JOIN nhacungcap ncc ON mp.manhacungcap = ncc.manhacungcap";

            // Gọi hàm get_data() để lấy dữ liệu vào DataTable
            DataTable dt = DB.get_data(sql);

            // Các tiêu đề cột bạn muốn xuất Excel cho phiếu nhập
            string[] titles = { "Mã Phiếu Nhập", "Thời gian tạo", "Người tạo", "Nhà cung cấp", "Tổng tiền" };

            // Gọi hàm ExportToExcel để xuất dữ liệu
            excel ex = new excel();
            ex.ExportToExcel(dt, "Danh Sách Phiếu Nhập", titles);
        }
    }
}
