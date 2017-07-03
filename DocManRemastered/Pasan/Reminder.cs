using docman.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocManRemastered.Pasan
{
    class Reminder
    {
        makeConnection conn = new makeConnection();
    
        public void upcomingDeadlines(DataGridView dv)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            DateTime today = getDate();
            DataTable dtRecord = new DataTable();
            SqlCommand readcommand = new SqlCommand("SELECT c.category_name ,f.* FROM files f,categories c where f.catID=category_ID and  dateadd(day,3,@today)>=f.deadline ", conn.connection());
            readcommand.Parameters.AddWithValue("@today", today);
            SqlDataAdapter adapter = new SqlDataAdapter(readcommand);
            try
            {
                adapter.Fill(dtRecord);
            }catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }

            dv.DataSource = dtRecord;
            dv.Columns[1].Visible = false;
            dv.Columns[2].Visible = false;
            dv.Columns[3].Visible = false;
            dv.Columns[6].Visible = false;
            dv.Columns[9].Visible = false;
            dv.Columns[10].Visible = false;

            readcommand.Dispose();
            dtRecord.Dispose();
            adapter.Dispose();
            



        }

        public void recentFiles(DataGridView dv)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();

            DateTime today = getDate();
            DataTable dtRecord = new DataTable();
            SqlCommand readcommand = new SqlCommand("SELECT c.category_name ,f.* FROM files f,categories c where f.catID=category_ID and  dateadd(day,-3,@today)<=f.date_Recieved ", conn.connection());
            readcommand.Parameters.AddWithValue("@today", today);
            SqlDataAdapter adapter = new SqlDataAdapter(readcommand);
            try
            {
                adapter.Fill(dtRecord);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }

            dv.DataSource = dtRecord;
            dv.Columns[1].Visible = false;
            dv.Columns[2].Visible = false;
            dv.Columns[3].Visible = false;
            dv.Columns[6].Visible = false;
            dv.Columns[9].Visible = false;
            dv.Columns[10].Visible = false;

            readcommand.Dispose();
            dtRecord.Dispose();
            adapter.Dispose();

        }

        private DateTime getDate()
        {
            return DateTime.Now.Date;
        }
    }
}
