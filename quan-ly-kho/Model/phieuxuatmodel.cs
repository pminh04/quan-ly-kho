using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    class phieuxuatmodel
    {
        public class PhieuXuat
        {
            private string maphieu;
            private DateTime thoigiantao;
            private string nguoitao;
            private float tongtien;
            private string makhachhang;

            public PhieuXuat()
            {
            }

            public PhieuXuat(string maphieu, DateTime thoigiantao, string nguoitao, float tongtien, string makhachhang)
            {
                this.maphieu = maphieu;
                this.thoigiantao = thoigiantao;
                this.nguoitao = nguoitao;
                this.tongtien = tongtien;
                this.makhachhang = makhachhang;
            }

            public string MaPhieu { get => maphieu; set => maphieu = value; }
            public DateTime ThoiGianTao { get => thoigiantao; set => thoigiantao = value; }
            public string NguoiTao { get => nguoitao; set => nguoitao = value; }
            public float TongTien { get => tongtien; set => tongtien = value; }
            public string MaKhachHang { get => makhachhang; set => makhachhang = value; }
        }

    }
}
