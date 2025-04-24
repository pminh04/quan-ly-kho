using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Controller
{
    internal class Sua
    {
        public static void sua_ncc(Model.nhacungcap ncc)
        {
            //Console.WriteLine(id + "," + ten + "," + sdt + "," + diachi);

            string sql = "UPDATE nhacungcap SET tennhacungcap = '" + ncc.Ten + "', sdt = '" + ncc.Sdt + "', diachi = '" + ncc.Diachi +
                 "' WHERE manhacungcap = '" + ncc.Id + "'";
            DB.insert(sql);
        }
        public static void sua_sp(Model.SanPhamModel sp)
        {
            string sql = "UPDATE sanpham SET tensanpham = N'" + sp.tensanpham +
                         "', xuatxu = N'" + sp.xuatxu +
                         "', maloaihang = '" + sp.maloaihang +
  "' WHERE masanpham = '" + sp.masanpham + "'";
            DB.insert(sql);
        }
        //SUAPHIEUNHAP
        public static void sua_pn(Model.phieunhapmodel pn)
        {
            string sql = "UPDATE phieunhap SET thoigiantao = '" + pn.thoigiantao +
                         "', nguoitao = N'" + pn.nguoitao +
                         "', manhacungcap = '" + pn.manhacungcap +
                         "', tongtien = '" + pn.tongtien +

  "' WHERE maphieu = '" + pn.maphieu + "'";
            DB.insert(sql);
        }
        //SUACHITIETPGIEU
        public static void sua_ctpn(Model.chitietphieunhap ctpn)
        {
            string sql = "UPDATE chitietphieunhap SET masanpham = '" + ctpn.masanpham +
                         "', soluong = '" + ctpn.soluong +
                         "', dongia = '" + ctpn.dongia +
                         "', tongtien = '" + ctpn.tongtien +

  "' WHERE maphieu = '" + ctpn.maphieu + "'";
            DB.insert(sql);
        }
        //UPDATE SOLUONG
        public static void UpdateSoLuong(string masanpham, int soluongupdate)
        {
            string sql = "UPDATE sanpham SET soluong = soluong + " + soluongupdate + " WHERE masanpham = '" + masanpham + "'";
            DB.insert(sql);
        }
    }
}
