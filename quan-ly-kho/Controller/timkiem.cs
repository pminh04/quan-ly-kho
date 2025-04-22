using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using QLVatTu;
using quan_ly_kho.View.nhaphang;
using quan_ly_kho.View.phieunhap;
using quan_ly_kho.View.phieuxuat;
using quan_ly_kho.View.sanpham;
using quan_ly_kho.View.thongke;
using quan_ly_kho.View.xuathang;
using System.Windows.Forms;

namespace quan_ly_kho.Controller
{
    internal class timkiem
    {

        public static void timkiemsp(DataGridView dgv, Model.SanPhamModel sp)
        {
            string whereClause = "sp.masanpham LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR sp.tensanpham LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR sp.xuatxu LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR sp.loaisanpham LIKE N'%" + sp.tukhoa + "%')";
            
            if (sp.loaitk == "--Chọn--")
            {
                string sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where"+
                                 "sp.masanpham LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR sp.tensanpham LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR sp.xuatxu LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR sp.loaisanpham LIKE N'%" + sp.tukhoa + "%')";
                DB.show_to_table(dgv, sql);
            }else if (sp.loaitk == "Mã sản phẩm")
            {
                string sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where sp.masanpham LIKE N'%" + sp.tukhoa + "%'";
                DB.show_to_table(dgv, sql);
            }
            else if (sp.loaitk == "Tên sản phẩm")
            {
                string sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where sp.tensanpham LIKE N'%" + sp.tukhoa + "%'";
                DB.show_to_table(dgv, sql);
            }
            else if (sp.loaitk == "Xuất xứ")
            {
                string sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where sp.xuatxu LIKE N'%" + sp.tukhoa + "%' ";
                DB.show_to_table(dgv, sql);
            }
            else if (sp.loaitk == "Loại hàng")
            {
                string sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where sp.loaisanpham LIKE N'%" + sp.tukhoa + "%'";
                DB.show_to_table(dgv, sql);
            }
        }

        //thongke
        public static void search_thongke_sp(DataGridView dgv, Model.thongke_model_sp tk)
        {
            //int from, to;
            //from = int.Parse(tk.From);
            //to = int.Parse(tk.To);

            string whereClause = "('" + tk.Xuatxu + "' = '-- Chọn dữ liệu --' OR sp.xuatxu LIKE N'%" + tk.Xuatxu + "%')";

            string havingClause = "";

            // Nếu cả From và To đều có giá trị
            if (!string.IsNullOrEmpty(tk.From) && !string.IsNullOrEmpty(tk.To))
            {
                havingClause = "ISNULL(SUM(ctpn.soluong), 0) >= " + tk.From +
                               " OR ISNULL(SUM(ctpn.soluong), 0) <= " + tk.To;
            }
            else if (!string.IsNullOrEmpty(tk.From))
            {
                havingClause = "ISNULL(SUM(ctpn.soluong), 0) >= " + tk.From;
            }
            else if (!string.IsNullOrEmpty(tk.To))
            {
                havingClause = "ISNULL(SUM(ctpn.soluong), 0) <= " + tk.To;
            }
            else
            {
                havingClause = "1=1"; // không lọc theo số lượng
            }

            if (tk.Loaisl == "--Chọn số lượng--")
            {
                string sql = "SELECT sp.masanpham, sp.tensanpham, sp.xuatxu, " +
                                "ISNULL(SUM(ctpx.soluong), 0) AS soluongxuat, " +
                                "ISNULL(SUM(ctpn.soluong), 0) AS soluongnhap " +
                                "FROM sanpham sp " +
                                "LEFT JOIN chitietphieuxuat ctpx ON sp.masanpham = ctpx.mascanpham " +
                                "LEFT JOIN chitietphieunhap ctpn ON sp.masanpham = ctpn.masanpham " +
                                "WHERE " + whereClause + " " +
                                "GROUP BY sp.masanpham, sp.tensanpham, sp.xuatxu " +
                                "HAVING " + havingClause + " " +
                                "ORDER BY sp.masanpham;";
                DB.show_to_table(dgv, sql);
            }
            else if (tk.Loaisl == "Số lượng nhập")
            {
                string sqlNhap = "SELECT sp.masanpham,sp.tensanpham,sp.xuatxu, " +
                                "ISNULL(SUM(ctpn.soluong), 0) AS soluongnhap " +
                                "FROM sanpham sp " +
                                "LEFT JOIN chitietphieunhap ctpn ON sp.masanpham = ctpn.masanpham " +
                                "WHERE " + whereClause + " " +
                                "GROUP BY sp.masanpham, sp.tensanpham, sp.xuatxu " +
                                "HAVING " + havingClause + " " +
                                "ORDER BY sp.masanpham;";

                DB.show_to_table(dgv, sqlNhap);
            }
            else if (tk.Loaisl == "Số lượng xuất")
            {
                string sqlXuat = "SELECT sp.masanpham,sp.tensanpham,sp.xuatxu, " +
                                "ISNULL(SUM(ctpx.soluong), 0) AS soluongxuat " +
                                "FROM sanpham sp " +
                                "LEFT JOIN chitietphieuxuat ctpx ON sp.masanpham = ctpx.masanpham " +
                                "WHERE " + whereClause + " " +
                                "GROUP BY sp.masanpham, sp.tensanpham, sp.xuatxu " +
                                "HAVING " + havingClause + " " +
                                "ORDER BY sp.masanpham;";

                DB.show_to_table(dgv, sqlXuat);
            }
            else
            {
                string sqlXuat = "SELECT masanpham,tensanpham,xuatxu, soluong " +
                                "FROM sanpham " +
                                "WHERE soluong between " + tk.From + " and " + tk.To;

                DB.show_to_table(dgv, sqlXuat);
            }

        }

        public static void search_thongke_kh(DataGridView dgv, Model.thongke_model_kh kh)
        {
            //int from, to, tienfrom, tiento;
            //from = int.Parse(kh.Khfrom);
            //to = int.Parse(kh.Khto);
            //tienfrom = int.Parse(kh.Khtienfrom);
            //tiento = int.Parse(kh.Khtiento);

            string sql = "SELECT kh.id AS makhachhang, kh.hoten AS tenkhachhang, " +
                          "COUNT(px.maphieu) AS soluongdonhang, SUM(px.tongtien) AS tonggiatri " +
                          "FROM khachhang kh " +
                          "INNER JOIN phieuxuat px ON kh.id = px.makhachhang " +
                          "GROUP BY kh.id, kh.hoten " +
                          "HAVING " +
                          "(" + (string.IsNullOrEmpty(kh.Khfrom) ? "1=1" : "COUNT(px.maphieu) >= " + kh.Khfrom) + ") AND " +
                          "(" + (string.IsNullOrEmpty(kh.Khto) ? "1=1" : "COUNT(px.maphieu) <= " + kh.Khto) + ") AND " +
                          "(" + (string.IsNullOrEmpty(kh.Khtienfrom) ? "1=1" : "SUM(px.tongtien) >= " + kh.Khtienfrom) + ") AND " +
                          "(" + (string.IsNullOrEmpty(kh.Khtiento) ? "1=1" : "SUM(px.tongtien) <= " + kh.Khtiento) + ") " +
                          "ORDER BY soluongdonhang DESC";

            DB.show_to_table(dgv, sql);
        }
    }
}
