using docman.Classes;
using DocManRemastered.Forms;
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
    public partial class SearchDoc : Form
    {

        searchUpdateDoc SD = new searchUpdateDoc();
        customNotification CN = new customNotification();
        //Tag tg = new Tag();
        String ID;
        public SearchDoc()
        {
            InitializeComponent();
        }

        private void SearchDoc_Load(object sender, EventArgs e)
        {
            SD.loadCategories(cats);
            CN.custom(lecs);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String word = keywordtxt.Text;
            SD.searchDocument(word,ref searchresults);
        }

        private void searchresults_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID=SD.docINFO(ref searchresults, ref lbldate, ref lblsender, ref  lbltopic, ref lblstatusdoc, ref lbldead, ref  notificationstxt);
            SD.toUpdate(ref searchresults, RecievedDatePicker, senderdoc, topic, status, deadlinedate, notify, lecs, keywords,cats);
            String ID2 = searchresults.SelectedRows[0].Cells[2].Value.ToString();
           // tg.tagDocs(ID2);

        }

        private void lbldead_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lecs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SD.updateDetails(ref searchresults, RecievedDatePicker, senderdoc, topic, status, deadlinedate, notify, lecs,keywords,cats);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Progress pr = new Progress(ID);
            pr.ShowDialog();
        }
    }
}
