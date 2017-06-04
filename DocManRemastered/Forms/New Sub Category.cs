using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocManRemastered
{
    public partial class New_Sub_Category : Form
    {

        private String Node;
        docman.Classes.Categories ctsSub;
        public New_Sub_Category()
        {
            InitializeComponent();
        }

        public New_Sub_Category(docman.Classes.Categories ctsSub)
        {
            InitializeComponent();
            this.ctsSub = ctsSub;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ctsSub.newSubCategory(ctsSub.getNodeText(),newSub.Text);
        }

        

        private void New_Sub_Category_Load(object sender, EventArgs e)
        {

        }

        public void setNode(String Node)
        {
            this.Node = Node;
        }

        public String getNode()
        {
            return Node;
        }

    }
}
