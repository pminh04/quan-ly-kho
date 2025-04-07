using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tu.model
{
    internal class nhacungcapmodel
    {
        public string manhacungcap { get; set; }
        public string tennhacungcap { get; set; }
        public string sodienthoai { get; set; }
        public string  diachi { get; set; }

        public nhacungcapmodel() { }

        public nhacungcapmodel(string manhacungcap, string tennhacungcap, string sodienthoai, string diachi)
        {
            this.manhacungcap = manhacungcap;
            this.tennhacungcap = tennhacungcap;
            this.sodienthoai = sodienthoai;
            this.diachi = diachi;
            
        }
        public override string ToString()
        {
            return "[{manhacungcap}] Tên nhà cung cấp: {tennhacungcap}, Số điện thoại: {sodienthoai}, Địa chỉ: {diachi}";
        }
    }
}
