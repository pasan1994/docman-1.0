using docman.Classes;
using DocManRemastered.Forms;
using DocManRemastered.Pasan;
using System;
using System.Collections;
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
        Tag tg = new Tag();
        
        String ID;
        ArrayList attachID=new ArrayList();
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
           
           SearchDoc sd1 = new SearchDoc();
            sd1.StartPosition = FormStartPosition.Manual;
            sd1.Left = 250;
            sd1.Top = 130;
           
            sd1.MdiParent = this.MdiParent;
            sd1.Show();
            this.Close();

            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Progress pr = new Progress(ID);
            pr.ShowDialog();
        }

        private void searchresults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = SD.docINFO(ref searchresults, ref lbldate, ref lblsender, ref lbltopic, ref lblstatusdoc, ref lbldead, ref notificationstxt);
            SD.toUpdate(ref searchresults, RecievedDatePicker, senderdoc, topic, status, deadlinedate, notify, lecs, keywords, cats);
            String ID2 = searchresults.SelectedRows[0].Cells[2].Value.ToString();
            tg.setGrid(tagDoc);
            tg.tagDocs(ID2);
        }

        private void tagDoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = SD.docINFO(ref tagDoc, ref lbldate, ref lblsender, ref lbltopic, ref lblstatusdoc, ref lbldead, ref notificationstxt);
           SD.toUpdate(ref tagDoc, RecievedDatePicker, senderdoc, topic, status, deadlinedate, notify, lecs, keywords, cats);

        }

        private void tagDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String word = keywordtxt.Text;
            SD.searchDocument(word, ref searchresults);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            String word = keywordtxt.Text;
            SD.searchDocument(word, ref toTagDoc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //String word = keywordtxt.Text;
          //  SD.searchDocument(word, ref toTagDoc,ID);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // foreach(String id in attachID)
            //    if(!id.Equals(toTagDoc.SelectedRows[0].Cells[2].Value.ToString()))
            //attachID.Add(toTagDoc.SelectedRows[0].Cells[2].Value.ToString());
        }
    }
}
