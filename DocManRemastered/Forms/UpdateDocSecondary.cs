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
    public partial class UpdateDocSecondary : Form
    {
        private DataGridView dv;
        searchUpdateDoc sd2 = new searchUpdateDoc();
        customNotification cn2 = new customNotification();
        Categories cat = new Categories();
        
        public UpdateDocSecondary()
        {
            InitializeComponent();
        }

        public UpdateDocSecondary(DataGridView dv,Categories cat)
        {
            InitializeComponent();
            this.dv = dv;
            this.cat = cat;
        }

        private void UpdateDocSecondary_Load(object sender, EventArgs e)
        {
            cn2.custom(custom);
            sd2.loadCategories(cate);
            sd2.toUpdate(ref dv ,RecievedDatePicker,sender1,topic,status,deadline,notify,custom,keywords,cate);
        }

        private void update_Click(object sender, EventArgs e)
        {
            sd2.updateDetails(ref dv, RecievedDatePicker, sender1, topic, status, deadline, notify, custom, keywords,cate);
            cat.formReload();
            
            this.Close();
           
        }
    }
}
