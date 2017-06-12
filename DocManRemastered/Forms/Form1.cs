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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "add your username here")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "add your username here";
                username.ForeColor = Color.Silver;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "add your password here")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "add your password here";
                Password.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ID = null;
            String usernametxt = username.Text;
            String passwordtxt = Password.Text;
            userLogin login = new userLogin();
            ID=login.userLog(usernametxt,passwordtxt);
            if (ID != null)
            {
                main mdi = new main();
                mdi.ShowDialog();
                this.Close();
            }
            else
            {
                username.Clear();
                Password.Clear();
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
