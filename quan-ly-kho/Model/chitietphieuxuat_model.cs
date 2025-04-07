using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    class chitietphieuxuat_model
    {
        public class ChiTietPhieuXuat
        {
            private string maphieu;
            private string masp;
            private int soluong;
            private float dongia;

            public ChiTietPhieuXuat()
            {
            }

            public ChiTietPhieuXuat(string maphieu, string masp, int soluong, float dongia)
            {
                this.maphieu = maphieu;
                this.masp = masp;
                this.soluong = soluong;
                this.dongia = dongia;
            }

            public string MaPhieu { get => maphieu; set => maphieu = value; }
            public string MaSanPham { get => masp; set => masp = value; }
            public int SoLuong { get => soluong; set => soluong = value; }
            public float DonGia { get => dongia; set => dongia = value; }
        }

    }
}
