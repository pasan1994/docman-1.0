using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace docman.Classes
{
    class userManagemnt
    {
        makeConnection conn = new makeConnection();
        String staffID = null;
        public void addNewUser(String designation, String firstName, String lastName, String username, String password, String email, String AccessLevel)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            try
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO Users (designation,firstName,lastName,username, password,email,accesslevel ) VALUES (@0, @1, @2,@3,@4,@5,@6)", conn.connection());


                insertCommand.Parameters.Add(new SqlParameter("@0", designation));
                insertCommand.Parameters.Add(new SqlParameter("@1", firstName));
                insertCommand.Parameters.Add(new SqlParameter("@2", lastName));
                insertCommand.Parameters.Add(new SqlParameter("@3", username));
                insertCommand.Parameters.Add(new SqlParameter("@4", password));
                insertCommand.Parameters.Add(new SqlParameter("@5", email));
                insertCommand.Parameters.Add(new SqlParameter("@6", AccessLevel));
                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();
                conn.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public String updateUserLoad(String username, ComboBox designation, TextBox firstName, TextBox lastName, TextBox email, ComboBox access, TextBox password)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            SqlCommand readcommand = new SqlCommand("SELECT * FROM Users WHERE username = @0", conn.connection());
            readcommand.Parameters.Add(new SqlParameter("@0", username));

            SqlDataReader reader = readcommand.ExecuteReader();
            while (reader.Read())
            {
                staffID = reader[1].ToString();
                designation.Text = reader[2].ToString();
                firstName.Text = reader[3].ToString();
                lastName.Text = reader[4].ToString();
                email.Text = reader[7].ToString();
                password.Text = reader[6].ToString();
                access.Text = reader[8].ToString();


            }
            readcommand.Dispose();
            reader.Close();
            conn.closeConnection();

            return staffID;
        }

        public void updateUser(String firstName, String lastName, String email, String access, String password, String designation)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            try
            {
                SqlCommand updateCommand = new SqlCommand("update Users set designation=@designation ,password=@password,firstName=@firstName,lastName=@lastName,email=@email,accesslevel=@accesslevel  where staffID=@staffID", conn.connection());

                updateCommand.Parameters.Add(new SqlParameter("@designation", designation));
                updateCommand.Parameters.Add(new SqlParameter("@password", password));
                updateCommand.Parameters.Add(new SqlParameter("@firstName", firstName));
                updateCommand.Parameters.Add(new SqlParameter("@lastName", lastName));
                updateCommand.Parameters.Add(new SqlParameter("@email", email));
                updateCommand.Parameters.Add(new SqlParameter("@accesslevel", access));
                updateCommand.Parameters.Add(new SqlParameter("@staffID", staffID));
                updateCommand.ExecuteNonQuery();
                updateCommand.Dispose();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);

            }
        }
    }
}
    