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

        public static void show_cbx_xuatxu(ComboBox cbx)
        {
            string sql = "Select distinct xuatxu from sanpham";
            DB.load1cbox(cbx, sql,"xuatxu");
        }

        public static void search_thongke(DataGridView dgv,Model.thongke_model tk)
        {
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
                                "('" + tk.Xuatxu + "' = '' OR sp.xuatxu LIKE '%" + tk.Xuatxu + "%') " +
                                "GROUP BY " +
                                "sp.masanpham, sp.tensanpham, sp.xuatxu " +
                                "HAVING " +
                                "('" + tk.From + "' IS NULL OR ISNULL(SUM(ctpn.soluong), 0) >= '" + tk.From + "') " +
                                "AND " +
                                "('" + tk.To + "' IS NULL OR ISNULL(SUM(ctpn.soluong), 0) <= '" + tk.To + "') " +
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
                                "('" + tk.Xuatxu + "' = '' OR sp.xuatxu LIKE '%" + tk.Xuatxu + "%') " +
                                "GROUP BY " +
                                "sp.masanpham, sp.tensanpham, sp.xuatxu " +
                                "HAVING " +
                                "('" + tk.From + "' IS NULL OR ISNULL(SUM(ctpx.soluong), 0) >= '" + tk.From + "') " +
                                "AND " +
                                "('" + tk.To + "' IS NULL OR ISNULL(SUM(ctpx.soluong), 0) <= '" + tk.To + "') " +
                                "ORDER BY " +
                                "sp.masanpham;";

                DB.show_to_table(dgv, sqlXuat);
            }

        }



    }
}
