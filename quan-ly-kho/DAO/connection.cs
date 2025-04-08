using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.DAO
{
    internal class connection
    {
        public static SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=quanlykho;Persist Security Info=True;User ID=sa;Password=123456");
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

        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        // open the connection 
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }


        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
