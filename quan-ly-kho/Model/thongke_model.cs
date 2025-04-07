using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    internal class thongke_model
    {
        string loaisl;
        string from;
        string to;
        string xuatxu;

        public thongke_model() { }
        public thongke_model(string loaisl, string from, string to, string xuatxu)
        {
            this.loaisl = loaisl;
            this.from = from;
            this.to = to;
            this.xuatxu = xuatxu;
        }

        public string Xuatxu { get => xuatxu; set => xuatxu = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string Loaisl { get => loaisl; set => loaisl = value; }
    }
}
