using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace quan_ly_kho.Controller
{
    internal class loaddata
    {
        public static void show_ncc(DataGridView dgv,string t)
        {
            string sql = "Select * from " + t;
            DB.show_to_table(dgv,sql);
        }
    }
}
