using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quan_ly_kho.Model;

namespace quan_ly_kho.Controller
{
    internal class Them
    {

        public static void them_ncc(Model.nhacungcap ncc)
        {
            //Console.WriteLine(id + "," + ten + "," + sdt + "," + diachi);

            string sql = "INSERT INTO nhacungcap (manhacungcap, tennhacungcap, sdt, diachi) VALUES ('" + ncc.Id + "','" + ncc.Ten + "','" +
                "" + ncc.Sdt + "','" + ncc.Diachi + "')";
            DB.insert(sql);
        }
        //themsp
        //them...
    }
}
