using docman.Classes;
using DocManRemastered.Pasan;
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
    public partial class uploadDoc : Form
    {
        uploadDocument up = new uploadDocument();
        searchUpdateDoc sd = new searchUpdateDoc();
        customNotification cn = new customNotification();
        public uploadDoc()
        {
            InitializeComponent();
        }

        private void uploadDoc_Load(object sender, EventArgs e)
        {
            sd.loadCategories(category);
            cn.custom(custom);
            up.nextDocID();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            up.upDoc(RecievedDatePicker, senderdoc, topic,status,deadline,notifications,custom,keywords,category);
            uploadDoc sd1 = new uploadDoc();
            sd1.StartPosition = FormStartPosition.Manual;
            sd1.Left = 250;
            sd1.Top = 130;

            sd1.MdiParent = this.MdiParent;
            sd1.Show();
            this.Close();
        }
    }
}
