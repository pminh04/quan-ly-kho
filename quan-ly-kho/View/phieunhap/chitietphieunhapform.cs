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

namespace quan_ly_kho.View.phieunhap
{
    public partial class chitietphieunhapform : Form
    {
       


       
        public chitietphieunhapform()
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
            phieunhapDAO dao = new phieunhapDAO(); // khởi tạo DAO
            DataTable dt = dao.SelectAll();  // lấy sp có trạng thái = 1

            if (dt != null && dt.Rows.Count > 0)
            {
                tablechitietphieunhap.DataSource = dt;
                tablechitietphieunhap.Columns["maphieu"].HeaderText = "Mã phiếu nhập";
                tablechitietphieunhap.Columns["thoigiantao"].HeaderText = "Thời gian tạo";
                tablechitietphieunhap.Columns["nguoitao"].HeaderText = "Người tạo";
                tablechitietphieunhap.Columns["manhacungcap"].HeaderText = "Mã nhà cung cấp";
                tablechitietphieunhap.Columns["tongtien"].HeaderText = "Tổng tiền";
            }
            else
            {
                tablechitietphieunhap.DataSource = null;
                MessageBox.Show("Không có dữ liệu.");
            }
        }

        private void tablechitietphieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string selectedMaphieu = "";
        private void tablechitietphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy mã phiếu từ cột "maphieu" trong dòng được chọn
                selectedMaphieu = tablechitietphieunhap.Rows[e.RowIndex].Cells["maphieu"].Value.ToString();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tablechitietphieunhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu nhập để sửa.");
                return;
            }

            DataGridViewRow selectedRow = tablechitietphieunhap.SelectedRows[0];

            string maphieu = selectedRow.Cells["maphieu"].Value.ToString();
            formsuachitietphieunhap frm = new formsuachitietphieunhap(maphieu);

            // Truyền mã phiếu qua form sửa
            frm.ShowDialog();
        }

        private void chitietphieunhapform_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (tablechitietphieunhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu nhập để xóa.");
                return;
            }

            // Lấy mã phiếu nhập từ dòng đã chọn
            DataGridViewRow selectedRow = tablechitietphieunhap.SelectedRows[0];
            string maphieu = selectedRow.Cells["maphieu"].Value.ToString();

            // Xác nhận xóa
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "Xóa phiếu nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xóa phiếu nhập khỏi cơ sở dữ liệu
                phieunhapDAO dao = new phieunhapDAO();
                int isDeleted = dao.Delete(maphieu);

                if (isDeleted>0)
                {
                    // Xóa dòng khỏi DataGridView
                    tablechitietphieunhap.Rows.RemoveAt(selectedRow.Index);
                    MessageBox.Show("Xóa phiếu nhập thành công.");
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập thất bại.");
                }
            }
        }

        private void btnxemchitiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedMaphieu))
            {
                MessageBox.Show("Vui lòng chọn một phiếu nhập để xem chi tiết.");
                return;
            }

            // Lấy chi tiết phiếu nhập theo mã phiếu đã chọn
            chitietphieunhapDAO dao = new chitietphieunhapDAO();
            DataTable dt = dao.SelectByMaphieu(selectedMaphieu);  // Truy vấn theo mã phiếu

            // Kiểm tra nếu có dữ liệu và hiển thị
            if (dt != null && dt.Rows.Count > 0)
            {
                formxemchitietphieunhap frm = new formxemchitietphieunhap();
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

            phieunhapDAO dao = new phieunhapDAO();
            DataTable dt = dao.SelectByGia(giaTu, giaDen);

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
    }
}
