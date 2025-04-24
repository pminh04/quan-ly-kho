using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.Model;

namespace quan_ly_kho.DAO
{
    internal class sanphamDAO
    {


        private SqlConnection con = connection.GetConnection();
        public bool TruSoLuong(string masanpham, int soluongTru)
        {
            
            try
            {
                con.Open();
                string sql = "UPDATE sanpham SET soluong = soluong - @soluongTru WHERE masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@soluongTru", soluongTru);
                cmd.Parameters.AddWithValue("@masanpham", masanpham);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi trừ số lượng: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public int Insert(SanPhamModel sp)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "INSERT INTO sanpham (masanpham, tensanpham, xuatxu, soluong, maloaihang) VALUES (@masanpham, @tensanpham, @xuatxu,@soluong, @maloaihang)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@masanpham", sp.masanpham);
                cmd.Parameters.AddWithValue("@tensanpham", sp.tensanpham);
                cmd.Parameters.AddWithValue("@xuatxu", sp.xuatxu);
                cmd.Parameters.AddWithValue("@soluong", sp.soluong);
                cmd.Parameters.AddWithValue("@maloaihang", sp.maloaihang);
               
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int Update(SanPhamModel sp)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "UPDATE sanpham SET tensanpham = @tensanpham, xuatxu=@xuatxu, maloaihang = @maloaihang WHERE masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@masanpham", sp.masanpham);
                cmd.Parameters.AddWithValue("@tensanpham", sp.tensanpham);
                cmd.Parameters.AddWithValue("@xuatxu", sp.xuatxu);
                cmd.Parameters.AddWithValue("@loaihang", sp.maloaihang);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
       

        public int Delete(string masanpham)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "DELETE FROM sanpham WHERE masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@masanpham", masanpham);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "SELECT * FROM sanpham";
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

        public DataTable SelectExist()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "SELECT sp.masanpham, sp.tensanpham, sp.xuatxu, sp.soluong, lh.tenloaihang FROM sanpham sp " +
                    "join loaihang lh on lh.maloaihang = sp.maloaihang";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SelectExist thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable SelectExistPhieu()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "SELECT masanpham, tensanpham, xuatxu, soluong, dongia FROM sanpham WHERE trangThai = 1";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SelectExist thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public int UpdateSoLuong(string masanpham, int soluong)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "UPDATE sanpham SET soluong = @soluong WHERE masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@masanpham", masanpham);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update số lượng thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int DeleteTrangThai(string masanpham)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "UPDATE sanpham SET trangthai = 0 WHERE masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@masanpham", masanpham);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ẩn sản phẩm thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public bool CheckTrungMa(string masanpham)
        {
            bool isExist = false;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM sanpham WHERE masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@masanpham", masanpham);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    isExist = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kiểm tra mã sản phẩm: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isExist;
        }

        public int GetSoLuongExist()
        {
            int count = 0;
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM sanpham WHERE trangthai = 1";
                SqlCommand cmd = new SqlCommand(sql, con);
                count = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lấy số lượng thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return count;
        }
    }
}

    

