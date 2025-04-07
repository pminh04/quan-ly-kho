using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tu.model
{
    internal class SanPhamModel
    {
        public string masanpham { get; set; }
        public string tensanpham { get; set; }
        public string xuatxu { get; set; }
        public int soluong { get; set; }
        public decimal dongia { get; set; }
        public int trangthai { get; set; }

        public SanPhamModel() { }

        public SanPhamModel(string masanpham, string tensanpham, string xuatxu, int soluong, decimal dongia, int trangthai = 1)
        {
            this.masanpham = masanpham;
            this.tensanpham = tensanpham;
            this.xuatxu = xuatxu;
            this.soluong = soluong;
            this.dongia = dongia;
            this.trangthai = trangthai;
        }

        public override string ToString()
        {
            return $"[{masanpham}] {tensanpham} - {xuatxu}, SL: {soluong}, Giá: {dongia}đ";
        }
    }

    
}




