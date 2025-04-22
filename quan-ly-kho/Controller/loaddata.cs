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
            string sql = "SELECT sp.masanpham, sp.tensanpham, sp.xuatxu, sp.soluong, " +
                         "ISNULL(SUM(ctpn.soluong), 0) AS SoLuongNhap, " +
                         "ISNULL(SUM(ctpx.soluong), 0) AS SoLuongXuat " +
                         "FROM sanpham sp " +
                         "LEFT JOIN chitietphieunhap ctpn ON sp.masanpham = ctpn.masanpham " +
                         "LEFT JOIN chitietphieuxuat ctpx ON sp.masanpham = ctpx.masanpham " +
                         "GROUP BY sp.masanpham, sp.tensanpham, sp.xuatxu, sp.soluong " +
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

        

        public static void show_px(DataGridView dgv)
        {
            string sql = "SELECT * FROM phieuxuat ORDER BY thoigiantao DESC";
            DB.show_to_table(dgv, sql);
        }

        public static void show_xh_sp(DataGridView dgv) 
        {
            string sql = "SELECT masanpham, tensanpham, xuatxu, soluong, dongia FROM sanpham WHERE trangThai = 1";
            DB.show_to_table(dgv, sql);
        }

        public static void show_sp_tk(DataGridView dgv)
        {
            string sql = "SELECT masanpham,tensanpham FROM sanpham WHERE trangThai = 1";
            DB.show_to_table(dgv, sql);
        }

        public static void show_ncc_tk(DataGridView dgv)
        {
            string sql = "SELECT manhacungcap,tennhacungcap FROM nhacungcap";
            DB.show_to_table(dgv, sql);
        }
        public static void show_kh_tk(DataGridView dgv)
        {
            string sql = "SELECT id,hoten FROM khachhang";
            DB.show_to_table(dgv, sql);
        }

    }
}
