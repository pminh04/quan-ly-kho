using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    internal class chitietphieunhap
    {
        public class chitietphieunhapmodel
        {
            public string maphieu { get; set; }
            public string masanpham { get; set; }
            public int soluong { get; set; }
            public float dongia { get; set; }

            public chitietphieunhapmodel() { }

            public chitietphieunhapmodel(string maphieu, string masanpham, int soluong, float dongia)
            {
                this.maphieu = maphieu;
                this.masanpham = masanpham;
                this.soluong = soluong;
                this.dongia = dongia;
            }
        }

    }
}
