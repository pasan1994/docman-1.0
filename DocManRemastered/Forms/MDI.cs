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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        Buttons Btnform;
        SearchDoc Srchdoc;
        uploadDoc upDoc;
        Categories Ctgrs;
        NewsFeed Nwsfd;
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
                f1.Close();
            Btnform = new Buttons();
                Btnform.MdiParent = this;
                Btnform.StartPosition = FormStartPosition.Manual;
                Btnform.Left = 250;
                Btnform.Top = 130;
                Btnform.Show();
                LblTitle.Text = "Manage Users";
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button1.BackColor = Color.LightBlue;
                button7.BackColor = Color.White;
                button6.BackColor = Color.White;

        }

        private void main_Load(object sender, EventArgs e)
        {
            button6.PerformClick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
                f1.Close();

            Srchdoc = new SearchDoc();
                Srchdoc.MdiParent = this;
                Srchdoc.StartPosition = FormStartPosition.Manual;
                Srchdoc.Left = 250;
                Srchdoc.Top = 130;
                Srchdoc.Show();
                LblTitle.Text = "Search Documents";
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button1.BackColor = Color.White;
                button7.BackColor = Color.LightBlue;
                button6.BackColor = Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
                f1.Close();

            upDoc = new uploadDoc();
                upDoc.MdiParent = this;
                upDoc.StartPosition = FormStartPosition.Manual;
                upDoc.Left = 250;
                upDoc.Top = 130;
                upDoc.Show();
                LblTitle.Text = "Upload Documents";
                button2.BackColor = Color.LightBlue;
                button3.BackColor = Color.White;
                button1.BackColor = Color.White;
                button7.BackColor = Color.White;
                button6.BackColor = Color.White;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
                f1.Close();
            Ctgrs = new Categories();
                Ctgrs.MdiParent = this;
                Ctgrs.StartPosition = FormStartPosition.Manual;
                Ctgrs.Left = 250;
                Ctgrs.Top = 130;
                Ctgrs.Show();
                LblTitle.Text = "Manage Categories";
                button2.BackColor = Color.White;
                button3.BackColor = Color.LightBlue;
                button1.BackColor = Color.White;
                button7.BackColor = Color.White;
                button6.BackColor = Color.White;

        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
                f1.Close();
            Nwsfd = new NewsFeed();
            Nwsfd.MdiParent = this;
            Nwsfd.StartPosition = FormStartPosition.Manual;
            Nwsfd.Left = 250;
            Nwsfd.Top = 130;
            Nwsfd.Show();
            LblTitle.Text = "News Feed";
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button1.BackColor = Color.White;
            button7.BackColor = Color.White;
            button6.BackColor = Color.LightBlue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
