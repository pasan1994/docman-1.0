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


namespace DocManRemastered
{
    public partial class Buttons : Form
    {
        userManagemnt user = new userManagemnt();
        public Buttons()
        {
            InitializeComponent();
            
        }

       private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == update){
               
                user.toCombo(username);
            }
        }

        private void username_SelectedIndexChanged(object sender, EventArgs e)
        {
            String usernametxt = username.SelectedValue.ToString();
            user.updateUserLoad(usernametxt,titleCombo,emailtxt,accesscombo,pass,confirmpass);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            String email = emailtxt.Text;
            String level = accesscombo.SelectedItem.ToString();
            String password = pass.Text;
            String title = titleCombo.SelectedItem.ToString(); ;
               
            MessageBox.Show(title);
            user.updateUser(email,level,password,title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String firstName = fnametxt.Text;
            String lastName = lNametxt.Text;
            String email = emailtxt1.Text;
            String access = levelcombo.SelectedItem.ToString();
            String username = usName.Text;
            String password = passwordtxt.Text;
            String title = titlecomboadd.SelectedItem.ToString();
            user.addNewUser(title,firstName,lastName,username,password,email,access);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
