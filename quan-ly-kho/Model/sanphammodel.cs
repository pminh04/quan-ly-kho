using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    internal class SanPhamModel
    {
        public string masanpham { get; set; }
        public string tensanpham { get; set; }
        public string xuatxu { get; set; }
        public int soluong { get; set; }
        public decimal dongia { get; set; }
        public int trangthai { get; set; }
        public string loaitk { get; set; }

        public string loaisanpham { get; set; }
        public string tukhoa { get; set; }

        public SanPhamModel() { }

        public SanPhamModel(string masanpham, string tensanpham, string xuatxu, int soluong, decimal dongia, string loaitk, string loaisanpham, string tukhoa, int trangthai = 1)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.xuatxu = xuatxu;
            this.soluong = soluong;
            this.dongia = dongia;
            this.trangthai = trangthai;
            this.loaitk = loaitk;
            this.loaisanpham = loaisanpham;
            this.tukhoa = tukhoa;
        }

        public SanPhamModel(string loaitk,string tukhoa)
        {
            this.loaitk = loaitk;
            this.tukhoa = tukhoa;
        }

        public override string ToString()
        {
            return $"[{masanpham}] {tensanpham} - {xuatxu}, SL: {soluong}, Giá: {dongia}đ";
        }
    }

    
}




