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
    class uploadDocument
    {
        makeConnection conn = new makeConnection();
        String ID;
        String ex = ".txt";

        public String nextDocID()
        {
            SqlCommand nextID;
            nextID = new SqlCommand("SELECT IDENT_CURRENT('files')+1", conn.connection());
            SqlDataReader reader = nextID.ExecuteReader();
            while (reader.Read())
                ID = reader[0].ToString();
            reader.Close();
            MessageBox.Show("Next Item ID is "+ID);
            nextID.Dispose();
            return ID;
        }


        public void setExtension(String ex)
        {
            this.ex = ex;
        }
        public void upDoc(DateTimePicker date, TextBox sender, TextBox topic, ComboBox status, DateTimePicker deadline, CheckedListBox notifications, CheckedListBox custom, RichTextBox keywords, ComboBox category)
        {
          
            SqlCommand insert;
           
            
            insert = new SqlCommand("insert into files(catID,sender,topic,doc_file,status) values (@category,@sender,@topic,@docFile,@status) ", conn.connection());
            insert.Parameters.AddWithValue("@category", category.SelectedValue);
            insert.Parameters.AddWithValue("@sender", sender.Text);
            insert.Parameters.AddWithValue("@topic", topic.Text);
            insert.Parameters.AddWithValue("@docFile", "C:\\docman\\"+ID+ex);
            insert.Parameters.AddWithValue("@status", status.SelectedItem.ToString());
            insert.ExecuteNonQuery();
            if (date.Checked == true)
            {
                insert = new SqlCommand("Update files SET date_Recieved=@date where doc_ID=" + ID + " ", conn.connection());
                insert.Parameters.AddWithValue("@date", date.Value);
                insert.ExecuteNonQuery();
            }
            else
            {
                insert = new SqlCommand("Update files SET date_Recieved=@date where doc_ID=" + ID + " ", conn.connection());
                insert.Parameters.AddWithValue("@date", DBNull.Value);
                insert.ExecuteNonQuery();

            }
            
           
            
            if (deadline.Checked == true)
            {
                insert = new SqlCommand("Update files SET  deadline=@deadline where doc_ID=" + ID + " ", conn.connection());
                insert.Parameters.AddWithValue("@deadline", deadline.Value);
                insert.ExecuteNonQuery();
            }
            else
            {
                insert = new SqlCommand("Update files SET  deadline=@deadline where doc_ID=" + ID + " ", conn.connection());
                insert.Parameters.AddWithValue("@deadline", DBNull.Value);
                insert.ExecuteNonQuery();
            }

            insert = new SqlCommand("Update files SET  keywords=@keywords where doc_ID=" + ID + " ", conn.connection());
            insert.Parameters.AddWithValue("@keywords", keywords.Text);
            insert.ExecuteNonQuery();
            getItems(notifications, false);
            getItems(custom,true);
            MessageBox.Show("Details were saved successfully");

            insert.Dispose();
           
        }
        private void getItems(CheckedListBox ch2, bool value)
        {

            SqlCommand insert = null;
          
            try
            {

                if (value == true)
                    foreach (object itemChecked in ch2.CheckedItems)
                    {
                        
                        DataRowView castedItem = itemChecked as DataRowView;
                        string id = castedItem["staffID"].ToString();
                                                                  
                        
                            insert = new SqlCommand("INSERT INTO customNotifications (docID,staffID) VALUES (@ID,@staffID)", conn.connection());
                            insert.Parameters.AddWithValue("@ID", ID);
                            insert.Parameters.AddWithValue("@staffID", id);
                            insert.ExecuteNonQuery();
                        




                    }

                if (value == false)
                    for (int x = 0; x < ch2.Items.Count; x++)
                    {
                      
                        if (ch2.GetItemChecked(x))
                        {

                          
                          
                              insert = new SqlCommand("INSERT INTO  notifications (docID,notified) VALUES (@ID,@notified)", conn.connection());
                                insert.Parameters.AddWithValue("@ID", ID);
                                insert.Parameters.AddWithValue("@notified", ch2.Items[x].ToString());
                                insert.ExecuteNonQuery();
                            

                        }


                    }
                if (insert != null)
                    insert.Dispose();

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }
    }
}
