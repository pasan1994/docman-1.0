using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace docman.Classes
{
    class searchUpdateDoc
    {
        makeConnection conn = new makeConnection();

        public void searchDocument(String name, ref DataGridView dv)
        {

            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();

            ArrayList table = new ArrayList();
            DataTable dtRecord = new DataTable();
            SqlCommand readcommand = new SqlCommand("SELECT category_name FROM categories", conn.connection());
            SqlDataReader reader = readcommand.ExecuteReader();
            while (reader.Read())

                table.Add(reader[0].ToString());
            reader.Close();
            readcommand.Dispose();
            String keyword = string.Format("%{0}%", name);
            foreach (String tbname in table)
            {
                SqlCommand readcommand2 = new SqlCommand("SELECT * FROM " + tbname + " where keywords LIKE @key ", conn.connection());

                readcommand2.Parameters.AddWithValue("@key", keyword);
                SqlDataAdapter adapter = new SqlDataAdapter(readcommand2);
                try
                {
                    adapter.Fill(dtRecord);


                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message);
                }
                readcommand2.Dispose();
                adapter.Dispose();
            }
            dv.DataSource = dtRecord;
            
            dtRecord.Dispose();




            //conn.closeConnection();

        }

        public void docINFO(ref DataGridView dv, ref Label lbldate, ref Label lblsender, ref Label lbltopic, ref Label lblstatus, ref Label lbldeadline, ref Label lblnotifications, ref Label lblprogress, ref RichTextBox txtkeywords)
        {
            bool custom = false;

            lbldate.Text = dv.SelectedRows[0].Cells[2].Value.ToString();
            lblsender.Text = dv.SelectedRows[0].Cells[3].Value.ToString();
            lbltopic.Text = dv.SelectedRows[0].Cells[4].Value.ToString();
            lblstatus.Text = dv.SelectedRows[0].Cells[6].Value.ToString();
            lbldeadline.Text = dv.SelectedRows[0].Cells[7].Value.ToString();
            
            txtkeywords.Text = dv.SelectedRows[0].Cells[9].Value.ToString();
            lblprogress.Text = dv.SelectedRows[0].Cells[10].Value.ToString();

            SqlCommand readcommand = new SqlCommand("SELECT notified from notifications where doc=" + dv.SelectedRows[0].Cells[0].Value.ToString() + " and docID=" + dv.SelectedRows[0].Cells[1].Value.ToString() +" ", conn.connection());
            SqlDataReader reader = readcommand.ExecuteReader();
            while (reader.Read())
            {
                lblnotifications.Text += reader[0].ToString()+"\n";
                if (reader[0].ToString() == "custom")
                    custom = true;

            }

            if (custom == true)
            {
                readcommand = new SqlCommand("SELECT u.designation,u.firstName,u.lastName as Lec from customNotifications c,Users u where c.doc=" + dv.SelectedRows[0].Cells[0].Value.ToString() + " and  c.docID=" + dv.SelectedRows[0].Cells[1].Value.ToString() + " and c.staffID=u.staffID ", conn.connection());
                reader = readcommand.ExecuteReader();
                while (reader.Read())
                {
                    lblnotifications.Text += reader[0].ToString() + "\n";
                }
            }

        }
        public void test(ref DataGridView dv,Label lblnotifications)
        {
            
            bool custom = false;
            SqlCommand readcommand = new SqlCommand("SELECT notified from notifications where doc='" + dv.SelectedRows[0].Cells[0].Value.ToString() + "' and docID=" + dv.SelectedRows[0].Cells[1].Value.ToString() + " ", conn.connection());
            SqlDataReader reader = readcommand.ExecuteReader();


            while (reader.Read())
            {
                lblnotifications.Text += reader[0].ToString() + "\n";
                if (reader[0].ToString() == "custom")
                    custom = true;

            }
            reader.Close();

            if (custom == true)
            {
                SqlCommand readcommand2 = new SqlCommand("SELECT u.designation,u.firstName,u.lastName as Lec from customNotifications c,Users u where c.doc='" + dv.SelectedRows[0].Cells[0].Value.ToString() + "' and  c.docID=" + dv.SelectedRows[0].Cells[1].Value.ToString() + " and c.staffID=u.staffID ", conn.connection());
                SqlDataReader reader2 = readcommand2.ExecuteReader();
                while (reader2.Read())
                {
                    lblnotifications.Text += reader[0].ToString();
                }
            }
        }

        public void toUpdate(ref DataGridView dv, DateTimePicker date, TextBox sender, TextBox topic, ComboBox status, DateTimePicker deadline, CheckedListBox notifications, CheckedListBox custom, RichTextBox keywords, RichTextBox progress)
        {
            date.Value = (DateTime)dv.SelectedRows[0].Cells[2].Value;
            sender.Text = dv.SelectedRows[0].Cells[3].Value.ToString();
            topic.Text = dv.SelectedRows[0].Cells[4].Value.ToString();
            status.Text = dv.SelectedRows[0].Cells[6].Value.ToString();
            deadline.Value = (DateTime)dv.SelectedRows[0].Cells[7].Value;
        
            keywords.Text = dv.SelectedRows[0].Cells[9].Value.ToString();
            progress.Text = dv.SelectedRows[0].Cells[10].Value.ToString();
        }

        public void updateDetails(ref DataGridView dv, DateTimePicker date, TextBox sender, TextBox topic, ComboBox status, DateTimePicker deadline, CheckedListBox notifications, CheckedListBox custom, RichTextBox keywords, RichTextBox progress)
        {
            String table = dv.SelectedRows[0].Cells[0].Value.ToString();
            String ID = dv.SelectedRows[0].Cells[1].Value.ToString();
          
            SqlCommand readcommand3;
            readcommand3 = new SqlCommand("Update" + table + " SET date_Recieved=@date where doc_ID=" + ID + " ", conn.connection());
            readcommand3.Parameters.AddWithValue("@date", date);
            readcommand3.ExecuteNonQuery();
            readcommand3 = new SqlCommand("Update" + table + " SET sender=@sender where doc_ID=" + ID + " ", conn.connection());
            readcommand3.Parameters.AddWithValue("@sender", sender);
            readcommand3.ExecuteNonQuery();
            readcommand3 = new SqlCommand("Update" + table + " SET topic=@topic where doc_ID=" + ID + " ", conn.connection());
            readcommand3.Parameters.AddWithValue("@topic", topic);
            readcommand3.ExecuteNonQuery();
        }
    }
}