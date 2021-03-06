﻿using System;
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
        ArrayList notifications = new ArrayList();
        ArrayList customNotifications = new ArrayList();

        public void searchDocument(String keyword, ref DataGridView dv)
        {

            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();

           
            DataTable dtRecord = new DataTable();
          
          
          SqlCommand readcommand2 = new SqlCommand("SELECT c.category_name ,f.* FROM files f,categories c where keywords LIKE '%'+@key+'%' and f.catID=category_ID", conn.connection());

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
            
            dv.DataSource = dtRecord;
            dv.Columns[1].Visible = false;
            dv.Columns[2].Visible = false;
            dv.Columns[3].Visible = false;
            dv.Columns[4].Visible = false;
            dv.Columns[5].Visible = false;
            dv.Columns[7].Visible = false;
            dv.Columns[8].Visible = false;
            dv.Columns[9].Visible = false;
          


            dtRecord.Dispose();

            


            conn.closeConnection();

        }

        public void searchDocument(String keyword, ref DataGridView dv,String ID)
        {

            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();


            DataTable dtRecord = new DataTable();


            SqlCommand readcommand2 = new SqlCommand("SELECT c.category_name ,f.* FROM files f,categories c where keywords LIKE '%'+@key+'%' and f.catID=category_ID Except select c.category_name ,f.* FROM files f,categories c,taggingDocs t where docID=@doc and t.tagdocID=f.doc_ID and f.catID=category_ID", conn.connection());

            readcommand2.Parameters.AddWithValue("@key", keyword);
            readcommand2.Parameters.AddWithValue("@doc", ID);
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

            dv.DataSource = dtRecord;
            dv.Columns[1].Visible = false;
            dv.Columns[2].Visible = false;
            dv.Columns[3].Visible = false;
            dv.Columns[4].Visible = false;
            dv.Columns[5].Visible = false;
            dv.Columns[7].Visible = false;
            dv.Columns[8].Visible = false;
            dv.Columns[9].Visible = false;



            dtRecord.Dispose();




            conn.closeConnection();

        }

        public String  docINFO(ref DataGridView dv, ref Label lbldate, ref Label lblsender, ref Label lbltopic, ref Label lblstatus, ref Label lbldeadline, ref RichTextBox lblnotifications)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            bool custom = false;

            lblnotifications.Clear();
            String ID= dv.SelectedRows[0].Cells[2].Value.ToString();
            lbldate.Text = dv.SelectedRows[0].Cells[3].Value.ToString();
              lblsender.Text = dv.SelectedRows[0].Cells[4].Value.ToString();
              lbltopic.Text = dv.SelectedRows[0].Cells[5].Value.ToString();
             lblstatus.Text = dv.SelectedRows[0].Cells[7].Value.ToString();
              lbldeadline.Text = dv.SelectedRows[0].Cells[8].Value.ToString();
              

            SqlCommand readcommand = new SqlCommand("SELECT notified from notifications where docID=" + dv.SelectedRows[0].Cells[2].Value.ToString()+ " ", conn.connection());
            SqlDataReader reader = readcommand.ExecuteReader();
            while (reader.Read())
            {
                lblnotifications.Text += reader[0].ToString()+"\n";
                
                if (reader[0].ToString() == "Custom")
                    custom = true;

            }

            reader.Close();
            if (custom == true)
            {
                readcommand = new SqlCommand("SELECT u.designation+''+u.firstName+''+u.lastName as Lec from customNotifications c,Users u where c.docID=" + dv.SelectedRows[0].Cells[2].Value.ToString() +" and c.staffID=u.staffID ", conn.connection());
                reader = readcommand.ExecuteReader();
                while (reader.Read())
                {
                    lblnotifications.Text += reader[0].ToString() + "\n";
                   
                }
            }
            reader.Close();
            readcommand.Dispose();
            conn.closeConnection();
            return ID;

        }
       

        public void toUpdate(ref DataGridView dv, DateTimePicker date, TextBox sender, TextBox topic, ComboBox status, DateTimePicker deadline, CheckedListBox notify, CheckedListBox custom, RichTextBox keywords, ComboBox category)
        {
           
            bool customNoty = false;

            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            try
            {
                
                category.Text = dv.SelectedRows[0].Cells[0].Value.ToString();
                if (dv.SelectedRows[0].Cells[3].Value != DBNull.Value)
                {
                    date.Value = (DateTime)(dv.SelectedRows[0].Cells[3].Value);
                    date.Checked = true;
                }
                else
                    date.Checked = false;
                sender.Text = dv.SelectedRows[0].Cells[4].Value.ToString();
                topic.Text = dv.SelectedRows[0].Cells[5].Value.ToString();
                status.Text = dv.SelectedRows[0].Cells[7].Value.ToString();
                if (dv.SelectedRows[0].Cells[8].Value != DBNull.Value)
                {
                    deadline.Value = (DateTime)dv.SelectedRows[0].Cells[8].Value;
                    deadline.Checked = true;
                }
                else
                    deadline.Checked = false;
                
                keywords.Text = dv.SelectedRows[0].Cells[9].Value.ToString();

                   

                SqlCommand readcommand = new SqlCommand("SELECT notified from notifications where docID=" + dv.SelectedRows[0].Cells[2].Value.ToString() + " ", conn.connection());
                SqlDataReader reader = readcommand.ExecuteReader();
               
                while (reader.Read())
                {
                    if (reader[0].ToString() == "Custom")
                        customNoty = true;
                    SetItemChecked(reader[0].ToString(),notify);
                    notifications.Add(reader[0].ToString());
                }
                reader.Close();

                readcommand=new SqlCommand("SELECT staffID from customNotifications  where docID=" + dv.SelectedRows[0].Cells[2].Value.ToString() + " ", conn.connection());
               reader = readcommand.ExecuteReader();
                while (reader.Read())
                {
                    customNotifications.Add(reader[0].ToString());
                    setItem(reader[0].ToString(), custom);
                }
                reader.Close();
                conn.closeConnection();

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void SetItemChecked(string item,CheckedListBox ch)
        {
            int index = GetItemIndex(item,ch);

            if (index < 0) return;

            ch.SetItemChecked(index, true);
           
        }

        private int GetItemIndex(string item,CheckedListBox ch)
        {
            int index = 0;

            foreach (object o in ch.Items)
            {
                if (item == o.ToString())
                {
                    
                    return index;
                }

                index++;
            }

            return -1;
        }


        private int getIndex(String id,CheckedListBox ch)
        {
            int index = 0;
           
            foreach (object o in ch.Items)
            {
                DataRowView castedItem = o as DataRowView;
                string id1 = castedItem["staffID"].ToString();
                if (id == id1)
                {

                    return index;
                }

                index++;
            }

            return -1;
        }

        private void setItem(String id,CheckedListBox ch)
        {
            int index = getIndex(id, ch);

            if (index < 0) return;

            ch.SetItemChecked(index, true);
        }

        public void updateDetails(ref DataGridView dv, DateTimePicker date, TextBox sender, TextBox topic, ComboBox status, DateTimePicker deadline, CheckedListBox notifications, CheckedListBox custom, RichTextBox keywords,ComboBox category)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();

            
            String ID = dv.SelectedRows[0].Cells[2].Value.ToString();
          
           SqlCommand readcommand3;
            readcommand3 = new SqlCommand("Update files SET catID=@category where doc_ID=" + ID + " ", conn.connection());
            readcommand3.Parameters.AddWithValue("@category",category.SelectedValue);
            readcommand3.ExecuteNonQuery();
            if (date.Checked == true)
            {
                readcommand3 = new SqlCommand("Update files SET date_Recieved=@date where doc_ID=" + ID + " ", conn.connection());
                readcommand3.Parameters.AddWithValue("@date", date.Value);
                readcommand3.ExecuteNonQuery();
            }
            else {
                readcommand3 = new SqlCommand("Update files SET date_Recieved=@date where doc_ID=" + ID + " ", conn.connection());
                readcommand3.Parameters.AddWithValue("@date", DBNull.Value);
                readcommand3.ExecuteNonQuery();

            }
            readcommand3 = new SqlCommand("Update files SET  sender=@sender where doc_ID=" + ID + " ", conn.connection());
            readcommand3.Parameters.AddWithValue("@sender", sender.Text);
            readcommand3.ExecuteNonQuery();
            readcommand3 = new SqlCommand("Update files SET  topic=@topic where doc_ID=" + ID + " ", conn.connection());
            readcommand3.Parameters.AddWithValue("@topic", topic.Text);
            readcommand3.ExecuteNonQuery();
            readcommand3 = new SqlCommand("Update files SET  status=@status where doc_ID=" + ID + " ", conn.connection());
            readcommand3.Parameters.AddWithValue("@status",status.SelectedItem.ToString());
            readcommand3.ExecuteNonQuery();
            if (deadline.Checked == true)
            {
                readcommand3 = new SqlCommand("Update files SET  deadline=@deadline where doc_ID=" + ID + " ", conn.connection());
                readcommand3.Parameters.AddWithValue("@deadline", deadline.Value);
                readcommand3.ExecuteNonQuery();
            } else
            {
                readcommand3 = new SqlCommand("Update files SET  deadline=@deadline where doc_ID=" + ID + " ", conn.connection());
                readcommand3.Parameters.AddWithValue("@deadline", DBNull.Value);
                readcommand3.ExecuteNonQuery();
            }
          
            readcommand3 = new SqlCommand("Update files SET  keywords=@keywords where doc_ID=" + ID + " ", conn.connection());
            readcommand3.Parameters.AddWithValue("@keywords", keywords.Text);
            readcommand3.ExecuteNonQuery();
            getItems(notifications,false,ID);
            getItems(custom,true,ID);



        }

        private void getItems(CheckedListBox ch2, bool value, String ID)
        {
           
            SqlCommand insert = null;
            bool check = true;
            try
            {

                if (value == true)
                    foreach (object itemChecked in ch2.CheckedItems)
                    {
                        check = true;
                        DataRowView castedItem = itemChecked as DataRowView;
                        string id = castedItem["staffID"].ToString();
                       
                        
                        foreach (String s in customNotifications)
                        
                          if (s==id)
                            
                                check = false;
                                                                                                                                         
                            if (check == true)
                            {
                           
                                insert = new SqlCommand("INSERT INTO customNotifications (docID,staffID) VALUES (@ID,@staffID)", conn.connection());
                                insert.Parameters.AddWithValue("@ID", ID);
                                insert.Parameters.AddWithValue("@staffID", id);
                                insert.ExecuteNonQuery();
                            }

                        


                    }

                if (value == false)
                    for (int x = 0; x < ch2.Items.Count; x++)
                    {
                        check = true;
                        if (ch2.GetItemChecked(x))
                        {
                          
                            foreach (String s in notifications)
                                if (ch2.Items[x].ToString() == s)
                                    check = false;
                            if(check==true)
                                {
                                    insert = new SqlCommand("INSERT INTO  notifications (docID,notified) VALUES (@ID,@notified)", conn.connection());
                                    insert.Parameters.AddWithValue("@ID", ID);
                                    insert.Parameters.AddWithValue("@notified", ch2.Items[x].ToString());
                                    insert.ExecuteNonQuery();
                                }
                            
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

        public void loadCategories(ComboBox cat)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();
            try
            {
                SqlCommand combo = new SqlCommand("select category_ID,category_name from categories", conn.connection());

                SqlDataAdapter ad = new SqlDataAdapter(combo);

                DataSet ds = new DataSet();
                ad.Fill(ds, "categories");
                cat.DisplayMember = "category_name";
                cat.ValueMember = "category_ID";
                cat.DataSource = ds.Tables["categories"];
               
                ds.Dispose();
                combo.Dispose();
                ad.Dispose();
                conn.closeConnection();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);

            }

        }


        public void progressLoad(String docID, DataGridView progress)
        {

            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();

            DataTable dtRecord = new DataTable();
         SqlCommand   readcommand = new SqlCommand("select * from progress where docID=@docID ", conn.connection());
            readcommand.Parameters.AddWithValue("@docID",docID);
            SqlDataAdapter adapter = new SqlDataAdapter(readcommand);
            try
            {
                adapter.Fill(dtRecord);


            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
            readcommand.Dispose();
            adapter.Dispose();

            progress.DataSource = dtRecord;
            dtRecord.Dispose();
            conn.closeConnection();
        }

        public void insertProgress(String ID,String progress, DateTime? deadline,String status)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();

            try
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO progress (docID,progress,deadline,status) VALUES (@0, @1, @2,@3)", conn.connection());


                insertCommand.Parameters.Add(new SqlParameter("@0", ID));
                insertCommand.Parameters.Add(new SqlParameter("@1", progress));
                insertCommand.Parameters.Add(new SqlParameter("@2", (object)deadline ?? DBNull.Value));
                insertCommand.Parameters.Add(new SqlParameter("@3", status));

                insertCommand.ExecuteNonQuery();
                insertCommand.Dispose();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            
            conn.closeConnection();
        }

        public void loadUpdateProgress(DataGridView dv ,RichTextBox rt, DateTimePicker dt, CheckBox ch)
        {
            rt.Text = dv.SelectedRows[0].Cells[2].Value.ToString();
            if (dv.SelectedRows[0].Cells[3].Value != DBNull.Value)
            {
                dt.Value = (DateTime)dv.SelectedRows[0].Cells[3].Value;
                dt.Checked = true;
            }
            else
                dt.Checked = false;
            if(dv.SelectedRows[0].Cells[4].Value.ToString()=="Resolved")
            ch.Checked = true;
            else
                ch.Checked = false;
        }

        public void updateProgress(DataGridView dv,RichTextBox rt,DateTime? dt,String ch)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();

            try
            {
                String ID = dv.SelectedRows[0].Cells[1].Value.ToString();
                SqlCommand readcommand3;
                readcommand3 = new SqlCommand("Update progress SET progress=@progress where progressID=" + ID + " ", conn.connection());
                readcommand3.Parameters.AddWithValue("@progress", rt.Text);
                readcommand3.ExecuteNonQuery();
                readcommand3 = new SqlCommand("Update progress SET deadline=@deadline where progressID=" + ID + " ", conn.connection());
                readcommand3.Parameters.AddWithValue("@deadline", (object)dt ?? DBNull.Value);
                readcommand3.ExecuteNonQuery();
                readcommand3 = new SqlCommand("Update progress SET status=@status where progressID=" + ID + " ", conn.connection());
                readcommand3.Parameters.AddWithValue("@status", ch);
                readcommand3.ExecuteNonQuery();
                readcommand3.Dispose();
                conn.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
        
    
}

