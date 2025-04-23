using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    public class phieuxuatmodel
    {
        public string maphieu { get; set; }
        public DateTime thoigiantao { get; set; }
        public string nguoitao { get; set; }
        public float tongtien { get; set; }
        public string makhachhang { get; set; }
        public string loaitk { get; set; }
        public string tukhoa { get; set; }

        public phieuxuatmodel() { }

        public phieuxuatmodel(string maphieu, DateTime thoigiantao, string nguoitao, float tongtien, string makhachhang)
        {
            this.maphieu = maphieu;
            this.thoigiantao = thoigiantao;
            this.nguoitao = nguoitao;
            this.tongtien = tongtien;
            this.makhachhang = makhachhang;
        }

        public phieuxuatmodel(string loaitk, string tukhoa)
        {
            this.loaitk = loaitk;
            this.tukhoa = tukhoa;
        }
    }
}
