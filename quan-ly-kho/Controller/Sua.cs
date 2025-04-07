using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.Controller
{
    internal class Sua
    {
        public static void sua_ncc(Model.nhacungcap ncc)
        {
            //Console.WriteLine(id + "," + ten + "," + sdt + "," + diachi);

            string sql = "UPDATE nhacungcap SET tennhacungcap = '" + ncc.Ten + "', sdt = '" + ncc.Sdt + "', diachi = '" + ncc.Diachi +
                 "' WHERE manhacungcap = '" + ncc.Id + "'";
            DB.insert(sql);
        }
    }
}
