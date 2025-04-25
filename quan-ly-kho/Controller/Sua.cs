using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string sql = "UPDATE chitietphieunhap SET soluong = '" + ctpn.soluong +
                  "', dongia = '" + ctpn.dongia +
                  "', tongtien = '" + ctpn.tongtien +
                  "' WHERE maphieu = '" + ctpn.maphieu + "' AND masanpham = '" + ctpn.masanpham + "'";
            DB.insert(sql);
        }
        //UPDATE SOLUONG
        public static void UpdateSoLuong(string masanpham, int soluongupdate)
        {
            string sql = "UPDATE sanpham SET soluong = soluong + " + soluongupdate + " WHERE masanpham = '" + masanpham + "'";
            DB.insert(sql);
        }
        public static void UpdateSoLuongtruTheoPhieu(string maphieu)
        {
            // SQL để trừ số lượng sản phẩm từ bảng sanpham dựa trên số lượng trong bảng chi tiết phiếu nhập
            string sql = @"
        UPDATE sanpham
        SET soluong = soluong - (
            SELECT ISNULL(SUM(ctpn.soluong), 0) 
            FROM chitietphieunhap ctpn
            WHERE ctpn.maphieu = '" + maphieu + @"' 
            AND ctpn.masanpham = sanpham.masanpham
        )
        WHERE EXISTS (
            SELECT 1 
            FROM chitietphieunhap ctpn
            WHERE ctpn.maphieu = '" + maphieu + @"' 
            AND ctpn.masanpham = sanpham.masanpham
        );
    ";

            // Gọi hàm insert với SQL đã viết
            DB.insert(sql);
        }



        public static void UpdateSoLuongtru(string masanpham, int soluongupdate)
        {
            string sql = "UPDATE sanpham SET soluong = soluong - " + soluongupdate + " WHERE masanpham = '" + masanpham + "'";
            DB.insert(sql);
        }
    }
}
