using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quan_ly_kho.DAO;
using System.Windows.Forms;
using System.Security.Principal;
using quan_ly_kho.Model;

namespace quan_ly_kho.DAO
{
    internal class AccountDAO
    {
        connection db = new connection();
        public DataTable getAllAccount()
        {
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT hoten,tendangnhap,email,vaitro FROM taikhoan", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            try
            {
                db.openConnection();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return dataTable;
        }

        public bool insertAccount(Account account)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO taikhoan (hoten, tendangnhap, matkhau, trangthai, email,vaitro)" +
                " VALUES (@hoten, @tendangnhap, @matkhau, @trangthai, @email,@vaitro)", db.getConnection);
                command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = account.hoten;
                command.Parameters.Add("@tendangnhap", SqlDbType.NVarChar).Value = account.tendangnhap;
                command.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = account.matkhau;
                command.Parameters.Add("@trangthai", SqlDbType.Int).Value = account.trangthai;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = account.email;
                command.Parameters.Add("@vaitro", SqlDbType.NVarChar).Value = account.vaitro;


                db.openConnection();

                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool updateAccount(Account account)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE taikhoan SET hoten = @hoten, matkhau = @matkhau, trangthai = @trangthai, email = @email WHERE tendangnhap = @tendangnhap", db.getConnection);
                command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = account.hoten;
                command.Parameters.Add("@tendangnhap", SqlDbType.NVarChar).Value = account.tendangnhap;
                command.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = account.matkhau;
                command.Parameters.Add("@trangthai", SqlDbType.Int).Value = account.trangthai;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = account.email;

                db.openConnection();

                if ((command.ExecuteNonQuery() == 1))
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool deleteAccount(string tendangnhap)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM taikhoan WHERE tendangnhap = @tendangnhap", db.getConnection))
                {
                    command.Parameters.Add("@tendangnhap", SqlDbType.NVarChar).Value = tendangnhap;
                    db.openConnection();
                    bool result = command.ExecuteNonQuery() > 0;
                    db.closeConnection();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool checkUsernameExists(string tendangnhap)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM taikhoan WHERE tendangnhap = @tendangnhap", db.getConnection);
                command.Parameters.Add("@tendangnhap", SqlDbType.NVarChar).Value = tendangnhap;

                db.openConnection();

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    db.closeConnection();
                    return true; 
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        public DataTable searchAccountByTerm(string term)
        {

            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM khachhang WHERE id LIKE '%' + @term + '%' OR fullname LIKE '%' + @term + '%'  OR email LIKE '%' + @term + '%' OR phone LIKE '%' + @term + '%' OR address LIKE '%' + @term + '%'", db.getConnection);
            cmd.Parameters.Add("@term", SqlDbType.NVarChar, 50).Value = term;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            try
            {
                db.openConnection();
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }

            return dataTable;

        }
    }
}
