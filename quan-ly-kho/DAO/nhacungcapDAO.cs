using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_kho.DAO
{

    public class nhacungcapDAO
    {
        private SqlConnection con = connection.GetConnection();
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            // lấy mới

            try
            {
                con.Open();
                string sql = "SELECT * FROM nhacungcap";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách nhà cung cấp: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
        public string GetMaNhaCungCapByTen(string tennhacungcap)
        {
            string manhacungcap = null;
            SqlConnection con = connection.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                string sql = "SELECT manhacungcap FROM nhacungcap WHERE tennhacungcap = @tennhacungcap";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@tennhacungcap", tennhacungcap);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    manhacungcap = dt.Rows[0]["manhacungcap"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy mã nhà cung cấp: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return manhacungcap;
        }

        public string GetTenNhaCungCapByMa(string manhacungcap)
        {
            string tennhacungcap = null;
            SqlConnection con = connection.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                string sql = "SELECT tennhacungcap FROM nhacungcap WHERE manhacungcap = @manhacungcap";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@manhacungcap", manhacungcap);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    tennhacungcap = dt.Rows[0]["tennhacungcap"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy ten nhà cung cấp: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return tennhacungcap;
        }


    }
}