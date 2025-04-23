using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    internal class nhacungcapmodel
    {
        public string manhacungcap { get; set; }
        public string tennhacungcap { get; set; }
        public string sodienthoai { get; set; }
        public string  diachi { get; set; }
        public string loaitk { get; set; }
        public string tukhoa { get; set; }

        public nhacungcapmodel() { }

        public nhacungcapmodel(string manhacungcap, string tennhacungcap, string sodienthoai, string diachi)
        {
            this.manhacungcap = manhacungcap;
            this.tennhacungcap = tennhacungcap;
            this.sodienthoai = sodienthoai;
            this.diachi = diachi;
            
        }
        public nhacungcapmodel(string loaitk,string tukhoa)
        {
            this.loaitk = loaitk;
            this.tukhoa = tukhoa;
        }
        public override string ToString()
        {
            return "[{manhacungcap}] Tên nhà cung cấp: {tennhacungcap}, Số điện thoại: {sodienthoai}, Địa chỉ: {diachi}";
        }
    }
}
