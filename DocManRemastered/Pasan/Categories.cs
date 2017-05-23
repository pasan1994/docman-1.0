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
    class Categories
    {
        TreeView view = new TreeView();
        makeConnection conn = new makeConnection();

        public void setTree(TreeView view)
        {
            this.view = view;
        }

        public void PopulateTreeView(int parentId, TreeNode parentNode)

        {


            SqlCommand readcommand = new SqlCommand("SELECT * from categories where parentCategory=" + parentId + "", conn.connection());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(readcommand);
            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);
            TreeNode childNode;




            foreach (DataRow dr in dt.Rows)

            {
                Console.WriteLine("Test1");
                TreeNode t = new TreeNode();
                t.Text = dr["category_ID"].ToString() + " - " + dr["category_name"].ToString();
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

                PopulateTreeView(Convert.ToInt32(dr["category_ID"].ToString()), childNode);

            }

        }
    }
}
