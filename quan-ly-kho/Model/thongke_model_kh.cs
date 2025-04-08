using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Model
{
    internal class thongke_model_kh
    {
        string khfrom;
        string khto;
        string khtienfrom;
        string khtiento;


        public thongke_model_kh(string khfrom, string khto, string khtienfrom,string khtiento)
        {
            this.khfrom = khfrom;
            this.khto = khto;
            this.khtienfrom = khtienfrom;
            this.khtiento = khtiento;

        }

        public string Khfrom { get => khfrom; set => khfrom = value; }
        public string Khto { get => khto; set => khto = value; }
        public string Khtienfrom { get => khtienfrom; set => khtienfrom = value; }
        public string Khtiento { get => khtiento; set => khtiento = value; }
    }
}
