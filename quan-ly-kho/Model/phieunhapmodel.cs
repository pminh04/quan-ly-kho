using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    public class phieunhapmodel
    {
        public string maphieu { get; set; }
        public DateTime? thoigiantao { get; set; }
        public string nguoitao { get; set; }
        public string manhacungcap { get; set; }
        public double tongtien { get; set; }
        public string loaitk { get; set; }
        public string tukhoa { get; set; }

        public phieunhapmodel() { }

        public phieunhapmodel(string maphieu, DateTime? thoigiantao, string nguoitao, string manhacungcap, double tongtien)
        {
            this.maphieu = maphieu;
            this.thoigiantao = thoigiantao;
            this.nguoitao = nguoitao;
            this.manhacungcap = manhacungcap;
            this.tongtien = tongtien;
        }
        public phieunhapmodel(string loaitk,string tukhoa)
        {
            this.loaitk = loaitk;
            this.tukhoa = tukhoa;
        }
        public override string ToString()
        {
            return "[{maphieu}] NCC: {manhacungcap}, Người tạo: {nguoitao}, Tổng tiền: {tongtien}đ";
        }
    }
}

