using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;
using static quan_ly_kho.Model.chitietphieuxuat_model;

namespace quan_ly_kho.Controller
{
    internal class loaddata
    {
        public static void show_ncc(DataGridView dgv,string t)
        {
            string sql = "Select * from " + t;
            DB.show_to_table(dgv,sql);
        }

        public static void show_thongke_sp(DataGridView dgv)
        {
            string sql = "SELECT sp.masanpham, sp.tensanpham, sp.xuatxu, " +
                         "ISNULL(SUM(ctpn.soluong), 0) AS SoLuongNhap, " +
                         "ISNULL(SUM(ctpx.soluong), 0) AS SoLuongXuat " +
                         "FROM sanpham sp " +
                         "LEFT JOIN chitietphieunhap ctpn ON sp.masanpham = ctpn.masanpham " +
                         "LEFT JOIN chitietphieuxuat ctpx ON sp.masanpham = ctpx.masanpham " +
                         "GROUP BY sp.masanpham, sp.tensanpham, sp.xuatxu " +
                         "ORDER BY sp.masanpham";


            DB.show_to_table(dgv, sql);
        }

        public static void show_thongke_kh(DataGridView dgv)
        {
            string sql = "SELECT kh.id AS makhachhang,kh.hoten AS tenkhachhang,COUNT(px.maphieu) AS soluongdonhang,SUM(px.tongtien) AS tonggiatri " +
                "FROM khachhang kh " +
                "INNER JOIN phieuxuat px ON kh.id = px.makhachhang " +
                "GROUP BY kh.id, kh.hoten " +
                "ORDER BY SoLuongDonHang DESC";

            DB.show_to_table(dgv, sql);
        }

        public static void show_cbx_xuatxu(ComboBox cbx)
        {
            string sql = "Select distinct xuatxu from sanpham";
            DB.load1cbox(cbx, sql,"xuatxu");
        }

        public static void search_thongke_sp(DataGridView dgv,Model.thongke_model_sp tk)
        {
            int from, to;
            from = int.Parse(tk.From);
            to = int.Parse(tk.To);
            if (tk.Loaisl == "--Chọn số lượng--")
            {
                return;
            }
            else if (tk.Loaisl == "Số lượng nhập")
            {
                string sqlNhap = "SELECT " +
                                "sp.masanpham, " +
                                "sp.tensanpham, " +
                                "sp.xuatxu, " +
                                "ISNULL(SUM(ctpn.soluong), 0) AS SoLuongNhap " +
                                "FROM sanpham sp " +
                                "LEFT JOIN chitietphieunhap ctpn ON sp.masanpham = ctpn.masanpham " +
                                "WHERE " +
                                "('" + tk.Xuatxu + "' = '-- Chọn dữ liệu --' OR sp.xuatxu LIKE '%" + tk.Xuatxu + "%') " +
                                "GROUP BY " +
                                "sp.masanpham, sp.tensanpham, sp.xuatxu " +
                                "HAVING " +
                                "(" + from + " IS NULL OR ISNULL(SUM(ctpn.soluong), 0) >= " + from + ") " +
                                "AND " +
                                "(" + to + " IS NULL OR ISNULL(SUM(ctpn.soluong), 0) <= " + to + ") " +
                                "ORDER BY " +
                                "sp.masanpham;";

                DB.show_to_table(dgv, sqlNhap);
            }
            else
            {
                string sqlXuat = "SELECT " +
                                "sp.masanpham, " +
                                "sp.tensanpham, " +
                                "sp.xuatxu, " +
                                "ISNULL(SUM(ctpx.soluong), 0) AS SoLuongXuat " +
                                "FROM sanpham sp " +
                                "LEFT JOIN chitietphieuxuat ctpx ON sp.masanpham = ctpx.masanpham " +
                                "WHERE " +
                                "('" + tk.Xuatxu + "' = '-- Chọn dữ liệu --' OR sp.xuatxu LIKE '%" + tk.Xuatxu + "%') " +
                                "GROUP BY " +
                                "sp.masanpham, sp.tensanpham, sp.xuatxu " +
                                "HAVING " +
                                "('" + from + "' IS NULL OR ISNULL(SUM(ctpx.soluong), 0) >= '" + from + "') " +
                                "AND " +
                                "('" + to + "' IS NULL OR ISNULL(SUM(ctpx.soluong), 0) <= '" + to + "') " +
                                "ORDER BY " +
                                "sp.masanpham;";

                DB.show_to_table(dgv, sqlXuat);
            }

        }

        public static void search_thongke_kh(DataGridView dgv,Model.thongke_model_kh kh)
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
