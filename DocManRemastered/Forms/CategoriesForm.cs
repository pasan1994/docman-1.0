﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using docman.Classes;

namespace DocManRemastered
{
    public partial class Categories : Form
    {

        docman.Classes.Categories cts = new docman.Classes.Categories();
     
        public Categories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewCategory cnc = new CreateNewCategory(this);
            cnc.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDocSecondary uds = new UpdateDocSecondary(categoryGrid,this);
            uds.ShowDialog();

        }

        private void Categories_Load(object sender, EventArgs e)
        {
            cts.setTree(cats);
            cts.PopulateTreeView(0,null);
            updateDoc.Enabled=false;
        }

        private void cats_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            cts.viewCategories(categoryGrid, e.Node.Text);
            cts.setNodeText(e.Node.Text);
        }

        private void newSub_Click(object sender, EventArgs e)
        {
            New_Sub_Category NSC = new New_Sub_Category(cts,this);
            NSC.ShowDialog();
            
        }

        private void categoryGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            updateDoc.Enabled = true;
        }

        public  void  formReload()
        {
            Categories sd1 = new Categories();
            sd1.StartPosition = FormStartPosition.Manual;
            sd1.Left = 250;
            sd1.Top = 130;

            sd1.MdiParent = this.MdiParent;
            sd1.Show();
            this.Close();
        }

        private void cats_MouseClick(object sender, MouseEventArgs e)
        {
            updateDoc.Enabled = false;
        }

        private void categoryGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            updateDoc.Enabled = true;
        }

        private void categoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
