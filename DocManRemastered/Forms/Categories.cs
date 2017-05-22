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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewCategory cnc = new CreateNewCategory();
            cnc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDocSecondary uds = new UpdateDocSecondary();
            uds.ShowDialog();

        }
    }
}
