using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Controller
{
    internal class Xoa
    {
        public static void xoa_ncc(Model.nhacungcap ncc)
        {

            string sql = "DELETE from nhacungcap where manhacungcap = '"+ ncc.Id +"'";
            DB.delete(sql);
        }
        public static void xoa_sp(string masanpham)
        {
            string sql = "DELETE FROM sanpham WHERE masanpham = '" + masanpham + "'";
            DB.delete(sql);
        }
        public static void xoa_pn(string maphieu)
        {
            string sql = "DELETE FROM phieunhap WHERE maphieu = '" + maphieu + "'";
            DB.delete(sql);
        }
        public static void xoa_ctpn(string maphieu)
        {
            string sql = "DELETE FROM chitietphieunhap WHERE maphieu = '" + maphieu + "'";
            DB.delete(sql);
        }
    }
}
