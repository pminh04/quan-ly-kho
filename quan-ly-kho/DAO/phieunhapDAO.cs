using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using quan_ly_kho.Model;

namespace quan_ly_kho.DAO
{
    internal class phieunhapDAO
    {
        private SqlConnection con = connection.GetConnection();

        public int Insert(phieunhapmodel pn)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "INSERT INTO phieunhap (maphieu, thoigiantao, nguoitao, manhacungcap, tongtien) VALUES (@maphieu, @thoigiantao, @nguoitao, @manhacungcap, @tongtien)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", pn.maphieu);
                cmd.Parameters.AddWithValue("@thoigiantao", pn.thoigiantao);
                cmd.Parameters.AddWithValue("@nguoitao", pn.nguoitao);
                cmd.Parameters.AddWithValue("@manhacungcap", pn.manhacungcap);
                cmd.Parameters.AddWithValue("@tongtien", pn.tongtien);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert phiếu nhập thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int Update(phieunhapmodel pn)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "UPDATE phieunhap SET thoigiantao = @thoigiantao, nguoitao = @nguoitao, manhacungcap = @manhacungcap, tongtien = @tongtien WHERE maphieu = @maphieu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", pn.maphieu);
                cmd.Parameters.AddWithValue("@thoigiantao", pn.thoigiantao);
                cmd.Parameters.AddWithValue("@nguoitao", pn.nguoitao);
                cmd.Parameters.AddWithValue("@manhacungcap", pn.manhacungcap);
                cmd.Parameters.AddWithValue("@tongtien", pn.tongtien);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật phiếu nhập thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public int Delete(string maphieu)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "DELETE FROM phieunhap WHERE maphieu = @maphieu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", maphieu);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xóa phiếu nhập thất bại: " + ex.Message);
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
                string sql = "SELECT * FROM phieunhap ORDER BY thoigiantao DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lấy danh sách phiếu nhập thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable SelectById(string maphieu)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string sql = "SELECT * FROM phieunhap WHERE maphieu = @maphieu";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@maphieu", maphieu);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lấy phiếu nhập theo mã thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

    }
}
