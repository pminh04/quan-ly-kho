using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.DAO
{
    internal class connection
    {
        public static SqlConnection con = new SqlConnection("Data Source=PMINHPRO;Initial Catalog=quanlykho;Persist Security Info=True;User ID=sa;Password=12345");
        public static SqlConnection GetConnection()
        {
           
            try
            {
                con.Open();
                Console.WriteLine("Kết nối SQL thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Kết nối SQL thất bại:" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return con;
        }
    }
}
