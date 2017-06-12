using docman.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocManRemastered.Pasan
{
    class userLogin
    {
        makeConnection conn = new makeConnection();

        public String userLog(String username, String password)
        {
            String ID = null;
            SqlCommand readcommand = new SqlCommand("SELECT staffID from Users where username=@username and password=@password", conn.connection());
            readcommand.Parameters.AddWithValue("@username", username);
            readcommand.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = readcommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ID = reader[0].ToString();
                    MessageBox.Show("Login Succesful");
                    return ID;
                }
            }else
            {
                MessageBox.Show("Login Failed. Please check your credentials");
                return null;
            }
            return null;
                    
        }

    }
}
