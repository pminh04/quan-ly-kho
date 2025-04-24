using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{

    public class chitietphieunhap
    {
        public string maphieu { get; set; }
        public string masanpham { get; set; }
        public int soluong { get; set; }
        public float dongia { get; set; }

        public float tongtien { get; set; }

        public string loaitk { get; set; }
        public string tukhoa { get; set; }
        public string tukhoadate { get; set; }



        public chitietphieunhap() { }

        public chitietphieunhap(string maphieu, string masanpham, int soluong, float dongia, float tongtien)
        {
            this.maphieu = maphieu;
            this.masanpham = masanpham;
            this.soluong = soluong;
            this.dongia = dongia;
            this.tongtien = tongtien;
        }
        public chitietphieunhap(string loaitk, string tukhoa, string tukhoadate)
        {
            this.loaitk = loaitk;
            this.tukhoa = tukhoa;
            this.tukhoadate = tukhoadate;
        }
    }

}

