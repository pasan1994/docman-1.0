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
        SqlDataAdapter adapter = new SqlDataAdapter();
        int i = 0;

        public void tagDocs(String docID)
        {
            SqlCommand readcommand;
            readcommand = new SqlCommand("SELECT tagdocID from taggingDocs where docID=@doc", conn.connection());
           
            readcommand.Parameters.AddWithValue("@doc",docID);
            readcommand.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(readcommand);
            if (adapter!=null)
            adapter.Fill(dtRecord);
           for(; i<dtRecord.Rows.Count;i++)
            {
                DataRow row = dtRecord.Rows[i];
                String ID = row["tagdocID"] as String;
                Console.WriteLine(ID);
                tagDocs(ID);
            }
        }
    }
}
