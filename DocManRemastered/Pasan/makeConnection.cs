using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace docman.Classes
{
    class makeConnection
    {
        SqlConnection mycon = new SqlConnection();
        public makeConnection(String user,String password,String server,String databse)
        {
            mycon.ConnectionString = "User="+ user + ";Password="+ password + ";Server="+server+";Database="+ databse + "; Integrated Security=false";
            try
            {
                mycon.Open();
                Console.WriteLine("ServerVersion: {0}", mycon.ServerVersion);
                Console.WriteLine("State: {0}", mycon.State);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
           
        }

        public makeConnection()
        {
            mycon.ConnectionString = "User=docman;Password=test1;Server=localhost;Database=docman; Integrated Security=false";
            try
            {
                mycon.Open();
                Console.WriteLine("ServerVersion: {0}", mycon.ServerVersion);
                Console.WriteLine("State: {0}", mycon.State);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        public SqlConnection connection()
        {
            return mycon;
        }

        public void closeConnection()
        {
            if(mycon.State==System.Data.ConnectionState.Open)
            mycon.Close();
        }
    }
}
