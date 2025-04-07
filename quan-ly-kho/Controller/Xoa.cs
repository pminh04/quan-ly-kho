using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Controller
{
    internal class Xoa
    {
        public static void xoa_ncc(Model.nhacungcap ncc)
        {

            string sql = "DELETE from nhacungcap where manhacungcap = '"+ ncc.Id +"'";
            DB.delete(sql);
        }
    }
}
