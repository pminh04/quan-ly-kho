﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tu.model;

namespace tu.database
{
    internal class sanphamDAO
    {


        private SqlConnection con = connection.GetConnection();

        public int Insert(SanPhamModel sp)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "INSERT INTO sanpham (masanpham, tensanpham, xuatxu, soluong, dongia, trangthai) VALUES (@masanpham, @tensanpham, @xuatxu,@soluong, @dongia, @trangthai)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@masanpham", sp.masanpham);
                cmd.Parameters.AddWithValue("@tensanpham", sp.tensanpham);
                cmd.Parameters.AddWithValue("@xuatxu", sp.xuatxu);
                cmd.Parameters.AddWithValue("@soluong", sp.soluong);
                cmd.Parameters.AddWithValue("@dongia", sp.dongia);
                cmd.Parameters.AddWithValue("@trangthai", sp.trangthai);
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
                string sql = "UPDATE sanpham SET tensanpham = @tensanpham, xuatxu=@xuatxu, soluong = @soluong, dongia = @dongia, trangthai = @trangthai WHERE masanpham = @masanpham";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@masanpham", sp.masanpham);
                cmd.Parameters.AddWithValue("@tensanpham", sp.tensanpham);
                cmd.Parameters.AddWithValue("@xuatxu", sp.xuatxu);
                cmd.Parameters.AddWithValue("@soluong", sp.soluong);
                cmd.Parameters.AddWithValue("@dongia", sp.dongia);
                cmd.Parameters.AddWithValue("@trangthai", sp.trangthai);
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

    

