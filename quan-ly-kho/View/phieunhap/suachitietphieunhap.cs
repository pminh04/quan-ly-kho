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

namespace quan_ly_kho.View.phieunhap
{
    public partial class suachitietphieunhap : Form
    {
        private string maphieu;
        private int selectedIndex = -1;
        public suachitietphieunhap(string maphieu)
        {
            InitializeComponent();
            this.maphieu = maphieu;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void suachitietphieunhap_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
            LoadSanPham();
            LoadChiTietPhieu();
        }

        private void LoadPhieuNhap()
        {
            phieunhapDAO dao = new phieunhapDAO();
            DataTable dt = dao.SelectById(maphieu);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtmaphieu.Text = row["maphieu"].ToString();
                txtnguoitao.Text = row["nguoitao"].ToString();
                txttongtien.Text = row["tongtien"].ToString();
                string mancc = row["manhacungcap"].ToString();

                nhacungcapDAO nccDAO = new nhacungcapDAO();
                //string tenncc = nccDAO.GetTenNhaCungCapByMa(mancc);
                //cbxnhacungcap.Text = tenncc;
            }
        }

        private void LoadSanPham()
        {
            sanphamDAO dao = new sanphamDAO();
            DataTable dt = dao.SelectExist();
            tablesanpham.DataSource = dt;
        }

        private void LoadChiTietPhieu()
        {
            chitietphieunhapDAO dao = new chitietphieunhapDAO();
            DataTable dt = dao.SelectByMaphieu(maphieu);
            tablenhaphang.DataSource = dt;
        }
    }
}
