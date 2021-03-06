﻿using docman.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocManRemastered.Forms
{
    public partial class Progress : Form
    {
        String ID;
        searchUpdateDoc SD = new searchUpdateDoc();
        customNotification cn = new customNotification();
        public Progress()
        {
            InitializeComponent();
        }

        public Progress(String ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void Progress_Load(object sender, EventArgs e)
        {
          
            SD.progressLoad(ID,progressView);
            cn.custom(lecs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime? deaddt =null;
            String statustxt = DBNull.Value.ToString();
           if (deadline.Checked)
                deaddt = deadline.Value;
            if (status.Checked)
                 statustxt = "Resolved";
            SD.insertProgress(ID,progresstxt.Text,deaddt,statustxt);

            this.Hide();
            Progress pr = new Progress(ID);
            pr.ShowDialog();
            this.Close();
        }

        private void progressView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime? deaddt = null;
            String statustxt = DBNull.Value.ToString();
            if (deadline.Checked)
                deaddt = deadline.Value;
            if (status.Checked)
                statustxt = "Resolved";
            SD.updateProgress(progressView,progresstxt,deaddt,statustxt);

            this.Hide();
            Progress pr = new Progress(ID);
            pr.ShowDialog();
            this.Close();
        }

        private void progressView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Progress pr = new Progress(ID);
            pr.ShowDialog();
            this.Close();
        }

        private void progressView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SD.loadUpdateProgress(progressView, progresstxt, deadline, status);
        }
    }
}
