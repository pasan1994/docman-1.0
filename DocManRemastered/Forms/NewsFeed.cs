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
    public partial class NewsFeed : Form
    {
        Reminder r = new Reminder();
        public NewsFeed()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewsFeed_Load(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.Date.ToString());
            r.upcomingDeadlines(updead);
            r.recentFiles(recent);
        }
    }
}
