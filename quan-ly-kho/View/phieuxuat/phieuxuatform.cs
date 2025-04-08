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
using quan_ly_kho.DAO;

namespace quan_ly_kho.View.phieuxuat
{
    public partial class phieuxuatform: Form
    {
        public phieuxuatform()
        {
            InitializeComponent();
            LoadTable();

        }

        private void importexcelbtn_Click(object sender, EventArgs e)
        {

        }

        private void suabtn_Click(object sender, EventArgs e)
        {

        }

        private void toolbox_Enter(object sender, EventArgs e)
        {

        }
        private void LoadTable()
        {
            phieuxuatDAO dao = new phieuxuatDAO(); // khởi tạo DAO cho phiếu xuất
            DataTable dt = dao.SelectAll();  // lấy tất cả phiếu xuất

            if (dt != null && dt.Rows.Count > 0)
            {
                tabctpx.DataSource = dt;

                tabctpx.Columns["maphieu"].HeaderText = "Mã phiếu xuất";
                tabctpx.Columns["thoigiantao"].HeaderText = "Thời gian tạo";
                tabctpx.Columns["nguoitao"].HeaderText = "Người tạo";
                tabctpx.Columns["makhachhang"].HeaderText = "Mã khách hàng";
                tabctpx.Columns["tongtien"].HeaderText = "Tổng tiền";

                tabctpx.Columns["tongtien"].DefaultCellStyle.Format = "#,##0.##";
            }
            else
            {
                tabctpx.DataSource = null;
                MessageBox.Show("Không có dữ liệu phiếu xuất.");
            }
        }

        private void tablechitietphieuxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void phieuxuatform_Load(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}
