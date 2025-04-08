using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quan_ly_kho.Model;

namespace quan_ly_kho.DAO
{
    internal class chitietphieuxuatDAO
    {
        private SqlConnection con = connection.GetConnection();

        public int Insert(chitietphieuxuatmodel ct)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "INSERT INTO chitietphieuxuat (maphieu, masanpham, soluong, dongia) VALUES (@maphieu, @masanpham, @soluong, @dongia)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", ct.maphieu);
                cmd.Parameters.AddWithValue("@masanpham", ct.masanpham);
                cmd.Parameters.AddWithValue("@soluong", ct.soluong);
                cmd.Parameters.AddWithValue("@dongia", ct.dongia);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert chi tiết phiếu xuat thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int DeleteByMaphieu(string maphieu)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "DELETE FROM chitietphieuxuat WHERE maphieu = @maphieu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", maphieu);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xóa chi tiết theo mã phiếu xuat thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public DataTable SelectByMaphieu(string maphieu)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "SELECT * FROM chitietphieuxuat WHERE maphieu = @maphieu";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@maphieu", maphieu);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lấy chi tiết phiếu xuat theo mã thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "SELECT * FROM chitietphieuxuat";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SelectAll thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public int Update(chitietphieuxuatmodel ct)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "UPDATE chitietphieuxuat SET soluong = @soluong, dongia = @dongia WHERE maphieu = @maphieu AND masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", ct.maphieu);
                cmd.Parameters.AddWithValue("@masanpham", ct.masanpham);
                cmd.Parameters.AddWithValue("@soluong", ct.soluong);
                cmd.Parameters.AddWithValue("@dongia", ct.dongia);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật chi tiết phiếu xuat thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

    }

}
