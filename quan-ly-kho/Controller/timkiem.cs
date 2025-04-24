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
using System.Data;

namespace quan_ly_kho.Controller
{
    internal class timkiem
    {
        public static DataTable timkiemtk(Model.Account tk)
        {
            DataTable dt = new DataTable();
            string sql = "";

            if (tk.loaitk == "--Chọn--")
            {
                sql = "select hoten,tendangnhap,vaitro,email from taikhoan where" +
                                 " hoten LIKE N'%" + tk.tukhoa + "%' " +
                                 "OR tendangnhap LIKE N'%" + tk.tukhoa + "%' " +
                                 "OR vaitro LIKE N'%" + tk.tukhoa + "%' " +
                                 "OR email LIKE N'%" + tk.tukhoa + "%'";
            }
            else if (tk.loaitk == "Họ tên")
            {
                sql = "select hoten,tendangnhap,vaitro,email from taikhoan where hoten LIKE N'%" + tk.tukhoa + "%'";
            }
            else if (tk.loaitk == "Tên người dùng")
            {
                sql = "select hoten,tendangnhap,vaitro,email from taikhoan where tendangnhap LIKE N'%" + tk.tukhoa + "%'";
            }
            else if (tk.loaitk == "Vai trò")
            {
                sql = "select hoten,tendangnhap,vaitro,email from taikhoan where vaitro LIKE N'%" + tk.tukhoa + "%'";
            }
            else if (tk.loaitk == "Email")
            {
                sql = "select hoten,tendangnhap,vaitro,email from taikhoan where email LIKE N'%" + tk.tukhoa + "%'";
            }


            dt = DB.selectsearch(sql);
            return dt;
        }
        public static DataTable timkiemctpx(Model.chitietphieuxuatmodel ctpx)
        {
            DataTable dt = new DataTable();
            string sql = "";

            if (ctpx.loaitk == "--Chọn--")
            {
                sql = "select * from phieuxuat where" +
                                " maphieu LIKE N'%" + ctpx.tukhoa + "%' " +
                                "OR thoigiantao LIKE N'%" + ctpx.tukhoa + "%' " +
                                "OR nguoitao LIKE N'%" + ctpx.tukhoa + "%' " +
                                "OR makhachhang LIKE N'%" + ctpx.tukhoa + "%' ";
            }
            else if (ctpx.loaitk == "Mã phiếu")
            {
                sql = "select * from phieuxuat where maphieu LIKE N'%" + ctpx.tukhoa + "%'";
            }
            else if (ctpx.loaitk == "Thời gian tạo")
            {
                sql = "select * from phieuxuat where CONVERT(VARCHAR, thoigiantao, 120) LIKE '%" + ctpx.tukhoadate + "%'";
            }
            else if (ctpx.loaitk == "Người tạo")
            {
                sql = "select * from phieuxuat where nguoitao LIKE N'%" + ctpx.tukhoa + "%' ";
            }
            else if (ctpx.loaitk == "Mã khách hàng")
            {
                sql = "select * from phieuxuat where makhachhang LIKE N'%" + ctpx.tukhoa + "%'";

            }

            dt = DB.selectsearch(sql);
            return dt;
        }
        public static DataTable timkiempx(Model.phieuxuatmodel px)
        {
            DataTable dt = new DataTable();
            string sql = "";

            if (px.loaitk == "--Chọn--")
            {
                sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where" +
                                 " masanpham LIKE N'%" + px.tukhoa + "%' " +
                                 "OR tensanpham LIKE N'%" + px.tukhoa + "%' " +
                                 "OR xuatxu LIKE N'%" + px.tukhoa + "%' " +
                                 "OR loaisanpham LIKE N'%" + px.tukhoa + "%'";
            }
            else if (px.loaitk == "Mã sản phẩm")
            {
                sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where masanpham LIKE N'%" + px.tukhoa + "%'";
            }


            dt = DB.selectsearch(sql);
            return dt;
        }
        public static DataTable timkiempn(Model.phieunhapmodel pn)
        {
            DataTable dt = new DataTable();
            string sql = "";

            if (pn.loaitk == "--Chọn--")
            {
                sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where" +
                                 " masanpham LIKE N'%" + pn.tukhoa + "%' " +
                                 "OR tensanpham LIKE N'%" + pn.tukhoa + "%' " +
                                 "OR xuatxu LIKE N'%" + pn.tukhoa + "%' " +
                                 "OR loaisanpham LIKE N'%" + pn.tukhoa + "%'";
            }
            else if (pn.loaitk == "Mã sản phẩm")
            {
                sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where masanpham LIKE N'%" + pn.tukhoa + "%'";
            }
            

            dt = DB.selectsearch(sql);
            return dt;
        }
        public static DataTable timkiemkh(Model.Customer kh)
        {
            DataTable dt = new DataTable();
            string sql = "";

            if (kh.loaitk == "--Chọn--")
            {
                sql = "select * from khachhang where" +
                                " id LIKE N'%" + kh.tukhoa + "%' " +
                                "OR hoten LIKE N'%" + kh.tukhoa + "%' " +
                                "OR email LIKE N'%" + kh.tukhoa + "%' " +
                                "OR sdt LIKE N'%" + kh.tukhoa + "%' " +
                                "OR diachi LIKE N'%" + kh.tukhoa + "%' ";
            }
            else if (kh.loaitk == "Mã khách hàng")
            {
                sql = "select * from khachhang where id LIKE N'%" + kh.tukhoa + "%'";
            }
            else if (kh.loaitk == "Tên khách hàng")
            {
                sql = "select * from khachhang where hoten LIKE N'%" + kh.tukhoa + "%'";
            }
            else if (kh.loaitk == "Email")
            {
                sql = "select * from khachhang where email LIKE N'%" + kh.tukhoa + "%' ";
            }
            else if (kh.loaitk == "Số điện thoại")
            {
                sql = "select * from khachhang where sdt LIKE N'%" + kh.tukhoa + "%'";

            }
            else if (kh.loaitk == "Địa chỉ")
            {
                sql = "select * from khachhang where diachi LIKE N'%" + kh.tukhoa + "%'";

            }

            dt = DB.selectsearch(sql);
            return dt;
        }
        public static DataTable timkiemctpn(Model.chitietphieunhap.chitietphieunhapmodel ctpn)
        {
            DataTable dt = new DataTable();
            string sql = "";

            if (ctpn.loaitk == "--Chọn--")
            {
                sql = "select * from phieunhap where" +
                                " maphieu LIKE N'%" + ctpn.tukhoa + "%' " +
                                "OR thoigiantao LIKE N'%" + ctpn.tukhoa + "%' " +
                                "OR nguoitao LIKE N'%" + ctpn.tukhoa + "%' " +
                                "OR manhacungcap LIKE N'%" + ctpn.tukhoa + "%' ";
            }
            else if (ctpn.loaitk == "Mã phiếu")
            {
                sql = "select * from phieunhap where maphieu LIKE N'%" + ctpn.tukhoa + "%'";
            }
            else if (ctpn.loaitk == "Thời gian tạo")
            { 
                    sql = "select * from phieunhap where CONVERT(VARCHAR, thoigiantao, 120) LIKE '%" + ctpn.tukhoadate + "%'";
            }
            else if (ctpn.loaitk == "Người tạo")
            {
                sql = "select * from phieunhap where nguoitao LIKE N'%" + ctpn.tukhoa + "%' ";
            }
            else if (ctpn.loaitk == "Mã nhà cung cấp")
            {
                sql = "select * from phieunhap where manhacungcap LIKE N'%" + ctpn.tukhoa + "%'";

            }

            dt = DB.selectsearch(sql);
            return dt;
        }
        public static DataTable timkiemncc(Model.nhacungcapmodel ncc)
        {
            DataTable dt = new DataTable();
            string sql = "";
            
            if (ncc.loaitk == "--Chọn--")
            {
                sql = "select * from nhacungcap where" +
                                " manhacungcap LIKE N'%" + ncc.tukhoa + "%' " +
                                "OR tennhacungcap LIKE N'%" + ncc.tukhoa + "%' " +
                                "OR sdt LIKE N'%" + ncc.tukhoa + "%' " +
                                "OR diachi LIKE N'%" + ncc.tukhoa + "%'";
            }
            else if (ncc.loaitk == "Mã nhà cung cấp")
            {
                sql = "select * from nhacungcap where manhacungcap LIKE N'%" + ncc.tukhoa + "%'";
            }
            else if (ncc.loaitk == "Tên nhà cung cấp")
            {
                sql = "select * from nhacungcap where tennhacungcap LIKE N'%" + ncc.tukhoa + "%'";
            }
            else if (ncc.loaitk == "Số điện thoại")
            {
                sql = "select * from nhacungcap where sdt LIKE N'%" + ncc.tukhoa + "%' ";
            }
            else if (ncc.loaitk == "Địa chỉ")
            {
                sql = "select * from nhacungcap where diachi LIKE N'%" + ncc.tukhoa + "%'";

            }
            dt = DB.selectsearch(sql);
            return dt;
        }
        public static DataTable timkiemsp(Model.SanPhamModel sp)
        {
            DataTable dt = new DataTable();
            string sql = "";

            if (sp.loaitk == "--Chọn--")
            {
                 sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where"+
                                 " masanpham LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR tensanpham LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR xuatxu LIKE N'%" + sp.tukhoa + "%' " +
                                 "OR loaisanpham LIKE N'%" + sp.tukhoa + "%'";
            }else if (sp.loaitk == "Mã sản phẩm")
            {
                 sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where masanpham LIKE N'%" + sp.tukhoa + "%'";
            }
            else if (sp.loaitk == "Tên sản phẩm")
            {
                 sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where tensanpham LIKE N'%" + sp.tukhoa + "%'";
            }
            else if (sp.loaitk == "Xuất xứ")
            {
                 sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where xuatxu LIKE N'%" + sp.tukhoa + "%' ";
            }
            else if (sp.loaitk == "Loại hàng")
            {
                 sql = "select masanpham, tensanpham,xuatxu,loaisanpham,dongia from sanpham where loaisanpham LIKE N'%" + sp.tukhoa + "%'";
                
            }
            dt = DB.selectsearch(sql);
            return dt;
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
