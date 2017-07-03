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
    class Tag
    {
        makeConnection conn = new makeConnection();
        DataGridView dv = new DataGridView();
        DataTable dtRecord = new DataTable();
        DataTable tagdoc = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        int i = 0;

       public void setGrid(DataGridView dv)
        {
            this.dv = dv;
            while (dv.Rows.Count > 0)
            {
                dv.Rows.RemoveAt(0);
            }
        }

        public void tagDocs(String docID)
        {
            if (conn.connection().State == System.Data.ConnectionState.Closed)
                conn.connection().Open();

          


            SqlCommand readcommand;
            readcommand = new SqlCommand("SELECT tagdocID from taggingDocs where docID=@doc", conn.connection());

            readcommand.Parameters.AddWithValue("@doc", docID);
            readcommand.ExecuteNonQuery();
           
         
              SqlDataAdapter adapter = new SqlDataAdapter(readcommand);
             if (adapter != null)
              adapter.Fill(dtRecord);
            for (; i < dtRecord.Rows.Count;)
            {
                DataRow row = dtRecord.Rows[i];
                String ID = row["tagdocID"].ToString();
               
                SqlCommand readcommand2 = new SqlCommand("SELECT c.category_name ,f.* FROM files f,categories c where doc_ID=@document and f.catID=category_ID", conn.connection());

                readcommand2.Parameters.AddWithValue("@document", ID);
                SqlDataAdapter adapter2 = new SqlDataAdapter(readcommand2);
                try
                {
                    adapter2.Fill(tagdoc);
                }catch(Exception f)
                {
                    MessageBox.Show(f.Message);
                }
                i++;
                readcommand2.Dispose();
                adapter2.Dispose();
                row.Delete();
                tagDocs(ID);
            }
            if (tagdoc.Rows.Count>0)
            {
                dv.DataSource = tagdoc;
                dv.Columns[1].Visible = false;
                dv.Columns[2].Visible = false;
                dv.Columns[3].Visible = false;
                dv.Columns[4].Visible = false;
                dv.Columns[5].Visible = false;
                dv.Columns[7].Visible = false;
                dv.Columns[8].Visible = false;
                dv.Columns[9].Visible = false;
            }
            readcommand.Dispose();
            adapter.Dispose();
            dtRecord.Dispose();
            tagdoc.Dispose();
            conn.closeConnection();
            

        }
    }
}
