using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Code
{
    class PasswordDAL
    {
        SqlConnection conn;
        public DataTable SelectPassAdmin(String PW)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConn.GetInstance();

            SqlDataAdapter sda = new SqlDataAdapter("Select Username,Password from Login where Password=@PW and Username = 'Admin'", conn);
            sda.SelectCommand.Parameters.AddWithValue("@PW", PW);
            sda.Fill(dt);
            conn.Close();
            return dt;

        }
        public DataTable UpdatePWAdmin(String PW)
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();

            SqlDataAdapter dad = new SqlDataAdapter("Update Login SET Password=@PW where Username='Admin'", conn);
            dad.SelectCommand.Parameters.AddWithValue("@PW", PW);
            //dad.SelectCommand.Parameters.AddWithValue("@UN", UN);
            dad.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable SelectPassWorker(String PW)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = DBConn.GetInstance();

            SqlDataAdapter sda = new SqlDataAdapter("Select Username,Password from Login where Password=@PW and Username = 'Worker'", conn);
            sda.SelectCommand.Parameters.AddWithValue("@PW", PW);
            sda.Fill(dt);
            conn.Close();
            return dt;

        }
        public DataTable UpdatePWWorker(String PW)
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();

            SqlDataAdapter dad = new SqlDataAdapter("Update Login SET Password=@PW where Username='Worker'", conn);
            dad.SelectCommand.Parameters.AddWithValue("@PW", PW);
            //dad.SelectCommand.Parameters.AddWithValue("@UN", UN);
            dad.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
