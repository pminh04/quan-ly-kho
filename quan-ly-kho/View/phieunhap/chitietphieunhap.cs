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
using quan_ly_kho.View.nhaphang;

namespace quan_ly_kho.View.phieunhap
{
    public partial class chitietphieunhap : Form
    {
        public chitietphieunhap()
        {
            InitializeComponent();
            LoadTable();
        }

        private int selectedIndex = -1;
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
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tablechitietphieunhap.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phiếu nhập để sửa.");
                return;
            }

            // Lấy dòng được chọn từ tablephieunhap
            DataGridViewRow selectedRow = tablechitietphieunhap.SelectedRows[0];

            // Lấy thông tin từ dòng được chọn
            string maphieu = selectedRow.Cells["maphieu"].Value.ToString();
            string nguoitao = selectedRow.Cells["nguoitao"].Value.ToString();
            string manhacungcap = selectedRow.Cells["manhacungcap"].Value.ToString();

            // Tạo đối tượng phiếu nhập
            phieunhapmodel phieu = new phieunhapmodel()
            {
                maphieu = maphieu,
                nguoitao = nguoitao,
                manhacungcap = manhacungcap
            };

            // Mở form nhập hàng và truyền phiếu nhập vào
            nhaphangform frm = new nhaphangform();
            frm.ShowDialog();
        }

        private void tablechitietphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIndex = e.RowIndex;
            }
        }
    }
}
