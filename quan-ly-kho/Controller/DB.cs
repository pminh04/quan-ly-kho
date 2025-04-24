using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quan_ly_kho.Model;

namespace quan_ly_kho.Controller
{
    internal class DB
    {
        public static SqlConnection con = new SqlConnection("Data Source=PMinhpro;Initial Catalog=quanlykho;Persist Security Info=True;User ID=sa;Password=123456");

        public static DataTable selectsearch(string sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            
            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;

            DataTable dt = new DataTable();
            ad.Fill(dt);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();

            return dt;
        }
        public static void insert(string sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public static void delete(string sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public static void show_to_table(DataGridView dgv, string sql)
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;//thực hiện lệnh

            DataTable dt = new DataTable();
            ad.Fill(dt);

            cmd.Dispose();
            con.Close();

            dgv.DataSource = dt;
            dgv.Refresh();
        }

        public static void loadcbox(ComboBox box, string sql, string ten, string ma)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;

            DataTable dt = new DataTable();
            ad.Fill(dt);

            cmd.Dispose();
            con.Close();

            DataRow r = dt.NewRow();
            r[ma] = "";
            r[ten] = "Chọn dữ liệu";
            dt.Rows.InsertAt(r, 0);


            box.Items.Clear();
            box.DataSource = dt;
            box.DisplayMember = ten;
            box.ValueMember = ma;
        }

        public static void load1cbox(ComboBox box, string sql, string dulieu)
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter ad = new SqlDataAdapter();
            ad.SelectCommand = cmd;

            DataTable dt = new DataTable();
            ad.Fill(dt);

            cmd.Dispose();
            con.Close();

            DataRow r = dt.NewRow();
            r[dulieu] = "-- Chọn dữ liệu --";
            dt.Rows.InsertAt(r, 0);


            box.Items.Clear();
            box.DataSource = dt;
            box.DisplayMember = dulieu;
            box.ValueMember = dulieu;

        }

        public static int count(string t)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "select count(*) from " + t;
            SqlCommand cmd = new SqlCommand(sql, con);

            int count = (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();

            return count;
        }

        public static String searchbyid(string t, string id, string t_id)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "SELECT " + t_id + " FROM " + t + " WHERE " + t_id + " = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            string result = cmd.ExecuteScalar()?.ToString();
            cmd.Dispose();
            con.Close();
            return result;
        }

        public static bool checkPK(string id,string t,string t_id)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "select count(*) from " + t + " where " + t_id +" ='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);

            int kq = (int)cmd.ExecuteScalar();

            if (kq > 0)
            {
                return true;
            }
            else { return false; }
        }

        //SHOWGIA

        public static DataTable SelectByGia(String t, float giaTu, float giaDen)
        {

            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "SELECT * FROM " + t + " WHERE tongtien BETWEEN @giaTu AND @giaDen";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@giaTu", giaTu);
            cmd.Parameters.AddWithValue("@giaDen", giaDen);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }


        //GỌIDUNGCHOEXXCEL
        public static DataTable get_data(string sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            cmd.Dispose();
            con.Close();

            return dt;
        }
    

        public static object selectgetdata(string sql)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(sql, con);
            object result = cmd.ExecuteScalar(); // dùng SELECT thì phải dùng ExecuteScalar hoặc ExecuteReader
            cmd.Dispose();
            con.Close();

            return result;
        }

        public static bool select(Model.Account acc)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "Select vaitro from taikhoan where tendangnhap = '" + acc.tendangnhap + "' and matkhau = '" + acc.matkhau + "' and trangthai = " + acc.trangthai;
            SqlCommand cmd = new SqlCommand(sql, con);

            string kq = (string)cmd.ExecuteScalar();

            if (kq == "admin")
            {
                return true;
            }
            else { return false; }
        }

        public static string CheckLoginError(Account acc)
        {
            // Giả sử bạn có thể truy cập database tại đây
            if(con.State == ConnectionState.Closed) { con.Open(); }
                

                // Kiểm tra nếu tài khoản tồn tại nhưng sai mật khẩu
                string queryUser = "SELECT COUNT(*) FROM taikhoan WHERE tendangnhap = @username";
                SqlCommand cmdUser = new SqlCommand(queryUser, con);
                cmdUser.Parameters.AddWithValue("@username", acc.tendangnhap);

                int userCount = (int)cmdUser.ExecuteScalar();
                if (userCount == 0)
                {
                    return "Tên đăng nhập không tồn tại.";
                }

                // Kiểm tra mật khẩu
                string queryPass = "SELECT COUNT(*) FROM taikhoan WHERE tendangnhap = @username AND matkhau = @password";
                SqlCommand cmdPass = new SqlCommand(queryPass, con);
                cmdPass.Parameters.AddWithValue("@username", acc.tendangnhap);
                cmdPass.Parameters.AddWithValue("@password", acc.matkhau);

                int loginSuccess = (int)cmdPass.ExecuteScalar();
                if (loginSuccess == 0)
                {
                    return "Sai mật khẩu.";
                }

                return "Lỗi không xác định.";
            }
        }


}

