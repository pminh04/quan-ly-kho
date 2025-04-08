using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_ly_kho.Controller
{
    internal class DB
    {
        public static SqlConnection con = new SqlConnection("Data Source=PMinhpro;Initial Catalog=quanlykho;Persist Security Info=True;User ID=sa;Password=123456");

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
            r["categoryID"] = "";
            r["categoryName"] = "Chọn loại sách";
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

        public static void searchbyid(string t,string id,string t_id)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string sql = "select * from '" + t + "'where '" + t_id + "' = '"+ id +"'";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Dispose();
            con.Close();

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


    }
}
