using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quan_ly_kho.Model;

namespace quan_ly_kho.Controller
{
    internal class Them
    {

        public static void them_ncc(Model.nhacungcap ncc)
        {
            //Console.WriteLine(id + "," + ten + "," + sdt + "," + diachi);

            string sql = "INSERT INTO nhacungcap (manhacungcap, tennhacungcap, sdt, diachi) VALUES ('" + ncc.Id + "','" + ncc.Ten + "','" +
                "" + ncc.Sdt + "','" + ncc.Diachi + "')";
            DB.insert(sql);
        }
        public static void them_sp(Model.SanPhamModel sp)
        {
            //Console.WriteLine(id + "," + ten + "," + sdt + "," + diachi);

            string sql = "INSERT INTO sanpham (masanpham, tensanpham, xuatxu, maloaihang, soluong) " +
             "VALUES ('" + sp.masanpham + "',N'" + sp.tensanpham + "',N'" + sp.xuatxu + "','" + sp.maloaihang + "', 0)";
            DB.insert(sql);
        }
        public static void them_pn(Model.phieunhapmodel pn)
        {
            //Console.WriteLine(id + "," + ten + "," + sdt + "," + diachi);

            string sql = "INSERT INTO phieunhap (maphieu, thoigiantao, nguoitao, manhacungcap, tongtien) " +
             "VALUES ('" + pn.maphieu + "','" + pn.thoigiantao + "',N'" + pn.nguoitao + "','" + pn.manhacungcap + "','" + pn.tongtien + "' )";
            DB.insert(sql);
        }
        public static void them_ctpn(Model.chitietphieunhap ctpn)
        {
            //Console.WriteLine(id + "," + ten + "," + sdt + "," + diachi);

            string sql = "INSERT INTO chitietphieunhap (maphieu, masanpham, soluong, dongia, tongtien) " +
             "VALUES ('" + ctpn.maphieu + "','" + ctpn.masanpham + "','" + ctpn.soluong + "','" + ctpn.dongia + "','" + ctpn.tongtien + "' )";
            DB.insert(sql);
        }
        //
        //themsp
        //them...
    }
}
