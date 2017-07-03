using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

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
                MessageBox.Show("New User Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public String updateUserLoad(String username, ComboBox title,TextBox email, ComboBox access, TextBox password,TextBox confirmPass)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            SqlCommand readcommand = new SqlCommand("SELECT * FROM Users WHERE username = @0", conn.connection());
            readcommand.Parameters.Add(new SqlParameter("@0", username));

            SqlDataReader reader = readcommand.ExecuteReader();
            while (reader.Read())
            {
                staffID = reader[0].ToString();
                title.Text = reader[1].ToString();
                email.Text = reader[6].ToString();
                password.Text = reader[5].ToString();
                confirmPass.Text= reader[5].ToString();
                access.Text = reader[7].ToString();


            }
            readcommand.Dispose();
            reader.Close();
            conn.closeConnection();

            return staffID;
        }

        public void updateUser(String email, String access, String password, String designation)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            try
            {
                SqlCommand updateCommand = new SqlCommand("update Users set designation=@designation ,password=@password,email=@email,accesslevel=@accesslevel  where staffID=@staffID", conn.connection());

                updateCommand.Parameters.Add(new SqlParameter("@designation", designation));
                updateCommand.Parameters.Add(new SqlParameter("@password", password));
                updateCommand.Parameters.Add(new SqlParameter("@email", email));
                updateCommand.Parameters.Add(new SqlParameter("@staffID", staffID));
                updateCommand.Parameters.Add(new SqlParameter("@accesslevel", access));

               
                updateCommand.ExecuteNonQuery();
                updateCommand.Dispose();
                conn.closeConnection(); 
                MessageBox.Show("User Updated Successfully");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);

            }
        }


        public void toCombo(ComboBox users)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            try
            {
                SqlCommand combo = new SqlCommand("select username from Users", conn.connection());

                SqlDataAdapter ad = new SqlDataAdapter(combo);
               
                DataSet ds = new DataSet();
                ad.Fill(ds, "Users");
                users.DisplayMember = "username";
                users.ValueMember = "username";
                users.DataSource = ds.Tables["Users"];
                Console.WriteLine("Done");
                ds.Dispose();
                combo.Dispose();
                conn.closeConnection();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);

            }

        }
        public void deleteUser()
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            SqlCommand delete=null;
            try
            {

                delete = new SqlCommand("DELETE from Users where staffID=@staffID ", conn.connection());
                delete.Parameters.AddWithValue("@staffID", staffID);
                delete.ExecuteNonQuery();
                MessageBox.Show("User deleted successfully");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            delete.Dispose();
            conn.closeConnection();
        }

    }
}
    