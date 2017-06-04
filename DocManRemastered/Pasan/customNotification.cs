using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace docman.Classes
{
    class customNotification
    {
        public void custom(CheckedListBox ch1)
        {
            makeConnection conn = new makeConnection();
            SqlCommand readcommand = new SqlCommand("SELECT designation+''+ firstName as lecName , staffID FROM Users", conn.connection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(readcommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            ch1.DataSource = ds.Tables[0];

            ch1.DisplayMember = "lecName";
            ch1.ValueMember = "staffID";                      





            readcommand.Dispose();
            dataAdapter.Dispose();
            dt.Dispose();
            ds.Dispose();
            conn.closeConnection();
        }



        public void customToCat(ComboBox ch1)
        {
            makeConnection conn = new makeConnection();
            SqlCommand readcommand = new SqlCommand("SELECT designation+''+ firstName as lecName , staffID FROM Users", conn.connection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(readcommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            ch1.DataSource = ds.Tables[0];

            ch1.DisplayMember = "lecName";
            ch1.ValueMember = "staffID";





            readcommand.Dispose();
            dataAdapter.Dispose();
            dt.Dispose();
            ds.Dispose();
            conn.closeConnection();
        }
    }
}
