using docman.Classes;
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
        }

        private void progressView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SD.loadUpdateProgress(progressView,progresstxt,deadline,status);
        }
    }
}
