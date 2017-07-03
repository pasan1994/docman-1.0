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
        Categories cat;
        public New_Sub_Category()
        {
            InitializeComponent();
        }

        public New_Sub_Category(docman.Classes.Categories ctsSub,Categories cat)
        {
            InitializeComponent();
            this.ctsSub = ctsSub;
            this.cat = cat;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ctsSub.newSubCategory(ctsSub.getNodeText(),newSub.Text);
            cat.formReload();
            
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
