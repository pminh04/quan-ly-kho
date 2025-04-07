using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text.Common;

namespace quan_ly_kho.Model
{
    public class nhacungcap
    {
        string id;
        string ten;
        string sdt;
        string diachi;

        public nhacungcap()
        {
        }

        public nhacungcap(string id)
        {
            this.id = id;
        }
        public nhacungcap(string id, string ten, string sdt,string diachi)
        {
            this.id = id;
            this.ten = ten;
            this.sdt = sdt;
            this.diachi = diachi;
        }

        
        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }

        
    }
}
