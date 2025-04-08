using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using quan_ly_kho.Model;
using System.Windows.Forms;
namespace quan_ly_kho.DAO
{
    public class phieuxuatDAO
    {
        private SqlConnection con = connection.GetConnection();

        public int Insert(phieuxuatmodel px)
        {
           // int result = 0;
            try
            {
                con.Open();
                string sql = "INSERT INTO phieuxuat (maphieu, nguoitao, thoigiantao, makhachhang, tongtien) " +
                             "VALUES (@maphieu, @nguoitao, @thoigiantao, @makhachhang, @tongtien)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", px.maphieu);
                cmd.Parameters.AddWithValue("@nguoitao", px.nguoitao);
                cmd.Parameters.AddWithValue("@thoigiantao", px.thoigiantao);
                cmd.Parameters.AddWithValue("@makhachhang", px.makhachhang);
                cmd.Parameters.AddWithValue("@tongtien", px.tongtien);

                return cmd.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm phiếu xuất: " + ex.Message);
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        public int Update(phieuxuatmodel px)
        {
            int result = 0;
            try
            {
                con.Open();
                string sql = "UPDATE phieuxuat SET thoigiantao = @thoigiantao, nguoitao = @nguoitao, tongtien = @tongtien, makhachhang = @makhachhang WHERE maphieu = @maphieu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", px.maphieu);
                cmd.Parameters.AddWithValue("@thoigiantao", px.thoigiantao);
                cmd.Parameters.AddWithValue("@nguoitao", px.nguoitao);
                cmd.Parameters.AddWithValue("@tongtien", px.tongtien);
                cmd.Parameters.AddWithValue("@makhachhang", px.makhachhang);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cập nhật phiếu xuất thất bại: " + ex.Message);
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
                string sql = "DELETE FROM phieuxuat WHERE maphieu = @maphieu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maphieu", maphieu);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xóa phiếu xuất thất bại: " + ex.Message);
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
                string sql = "SELECT * FROM phieuxuat ORDER BY thoigiantao DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lấy danh sách phiếu xuất thất bại: " + ex.Message);
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
                string sql = "SELECT * FROM phieuxuat WHERE maphieu = @maphieu";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@maphieu", maphieu);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lấy phiếu xuất theo mã thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable SelectByGia(float giaTu, float giaDen)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                string sql = "SELECT * FROM phieuxuat WHERE tongtien BETWEEN @giaTu AND @giaDen";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.SelectCommand.Parameters.AddWithValue("@giaTu", giaTu);
                adapter.SelectCommand.Parameters.AddWithValue("@giaDen", giaDen);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lấy phiếu xuất theo giá thất bại: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
