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
  public  class Categories
    {
        TreeView view = new TreeView();
        makeConnection conn = new makeConnection();
        String nodeText = null;

        public void setTree(TreeView view)
        {
            this.view = view;
        }

        public void setNodeText(String node)
        {
            nodeText = node;
        }

        public String getNodeText()
        {
            return nodeText;
        }


        public void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            SqlCommand readcommand = null;
            if (parentId == 0)
            {
                readcommand = new SqlCommand("SELECT * from categories where parentCategory IS NULL", conn.connection());
            }
            else
             readcommand = new SqlCommand("SELECT * from categories where parentCategory=" + parentId + "", conn.connection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(readcommand);
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);
            TreeNode childNode;




            foreach (DataRow dr in dt.Rows)

            {
               
                TreeNode t = new TreeNode();
                t.Text =dr["category_name"].ToString();
                t.Name = dr["category_ID"].ToString();
                t.Tag = dt.Rows.IndexOf(dr);
                if (parentNode == null)
                {
                    view.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }
                readcommand.Dispose();
                dataAdapter.Dispose();
                dt.Dispose();
                PopulateTreeView(Convert.ToInt32(dr["category_ID"].ToString()), childNode);

            }

        }

        public void viewCategories(DataGridView dv,String  catName)
        {
            SqlCommand files = new SqlCommand("SELECT c.category_name,f.* from files f,categories c where f.catID=c.category_ID and c.category_name=@name ", conn.connection());
            files.Parameters.AddWithValue("@name", catName);
            Console.WriteLine(catName);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(files);
            DataTable dt = new DataTable();
            try
            {
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dv.DataSource=dt;
            dt.Dispose();
            dataAdapter.Dispose();
            files.Dispose();
        }

        public void newMainCategory(String name,String ID)
        {
            SqlCommand cat = new SqlCommand("INSERT INTO categories (category_name,category_staff) VALUES (@name,@ID) ", conn.connection());
            cat.Parameters.AddWithValue("@name", name);
            cat.Parameters.AddWithValue("@ID", ID);
            cat.ExecuteNonQuery();
        }
       
        public void newSubCategory(String Node,String newSub)
        {
            String ID = null;
            SqlCommand id = new SqlCommand("SELECT category_ID from categories where category_name=@category ", conn.connection());
            id.Parameters.AddWithValue("@category", Node);
            SqlDataReader reader = id.ExecuteReader();
            while (reader.Read())
            {
                ID = reader[0].ToString();
            }
            reader.Close();
            SqlCommand subCat = new SqlCommand("INSERT INTO categories (category_name,parentCategory) VALUES (@name,@ID) ", conn.connection());
            subCat.Parameters.AddWithValue("@name", newSub);
            subCat.Parameters.AddWithValue("@ID", ID);
            subCat.ExecuteNonQuery();

        }


    }
}
