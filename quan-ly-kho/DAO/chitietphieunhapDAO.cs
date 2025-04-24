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
    internal class chitietphieunhapDAO
    {
        private SqlConnection con = connection.GetConnection();

        public int Insert(chitietphieunhap ct)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "INSERT INTO chitietphieunhap (maphieu, masanpham, soluong, dongia) VALUES (@maphieu, @masanpham, @soluong, @dongia)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", ct.maphieu);
                cmd.Parameters.AddWithValue("@masanpham", ct.masanpham);
                cmd.Parameters.AddWithValue("@soluong", ct.soluong);
                cmd.Parameters.AddWithValue("@dongia", ct.dongia);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert chi tiết phiếu nhập thất bại: " + ex.Message);
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
                string sql = "DELETE FROM chitietphieunhap WHERE maphieu = @maphieu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", maphieu);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xóa chi tiết theo mã phiếu nhập thất bại: " + ex.Message);
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
                string sql = "SELECT * FROM chitietphieunhap WHERE maphieu = @maphieu";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@maphieu", maphieu);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lấy chi tiết phiếu nhập theo mã thất bại: " + ex.Message);
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
                string sql = "SELECT * FROM chitietphieunhap";
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

        public int Update(chitietphieunhap ct)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "UPDATE chitietphieunhap SET soluong = @soluong, dongia = @dongia WHERE maphieu = @maphieu AND masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", ct.maphieu);
                cmd.Parameters.AddWithValue("@masanpham", ct.masanpham);
                cmd.Parameters.AddWithValue("@soluong", ct.soluong);
                cmd.Parameters.AddWithValue("@dongia", ct.dongia);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật chi tiết phiếu nhập thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

    }

}

