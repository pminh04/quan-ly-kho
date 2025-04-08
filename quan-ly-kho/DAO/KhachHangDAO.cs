using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using quan_ly_kho.Model;

namespace quan_ly_kho.DAO
{
    internal class KhachHangDAO
    {
        connection db = new connection();
        public DataTable getAllKhachHang()
        {
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM khachhang", db.getConnection);
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

        public bool insertKhachHang(Customer customer)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO khachhang (id, hoten, email, sdt, diachi)" +
                " VALUES (@id, @hoten, @email, @sdt, @diachi)", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = customer.id;
                command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = customer.hoten;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customer.email;
                command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = customer.sdt;
                command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = customer.diachi;

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

        public bool updateKhachHang(Customer customer)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE khachhang SET hoten = @hoten, email = @email, sdt = @sdt, diachi = @diachi WHERE id = @id", db.getConnection);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value = customer.id;
                command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = customer.hoten;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = customer.email;
                command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = customer.sdt;
                command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = customer.diachi;

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

        public bool deleteKhachHang(string id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM khachhang WHERE id = @id", db.getConnection))
                {
                    command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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

        public string getNextKhachHangCode()
        {
            string query = "SELECT TOP 1 id FROM khachhang ORDER BY id DESC";

            try
            {
                SqlCommand command = new SqlCommand(query, db.getConnection);
                db.openConnection();

                object result = command.ExecuteScalar();
                db.closeConnection();

                if (result != null && result is string lastCode && lastCode.StartsWith("KH"))
                {
                    string numberPart = lastCode.Substring(2);
                    if (int.TryParse(numberPart, out int currentNumber))
                    {
                        int nextNumber = currentNumber + 1;
                        return "KH" + nextNumber.ToString("D3");
                    }
                }

                return "KH001";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
            }
        }


        public DataTable searchKhachHangByTerm(string term)
        {

            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM khachhang WHERE id LIKE '%' + @term + '%' OR hoten LIKE '%' + @term + '%'  OR email LIKE '%' + @term + '%' OR sdt LIKE '%' + @term + '%' OR diachi LIKE '%' + @term + '%'", db.getConnection);
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
