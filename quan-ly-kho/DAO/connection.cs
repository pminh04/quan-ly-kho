using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tu.database
{
    internal class connection
    {
        public static SqlConnection con = new SqlConnection("Data Source = MSI; Initial Catalog = quanlikho; Persist Security Info = True; User ID = sa; Password = 123456");
        public static SqlConnection GetConnection()
        {
           
            try
            {
                con.Open();
                Console.WriteLine("Kết nối SQL thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kết nối SQL thất bại: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            return con;
        }
    }
}
