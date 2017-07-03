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

namespace DocManRemastered
{
    public partial class CreateNewCategory : Form
    {
        customNotification newMain = new customNotification();
        docman.Classes.Categories newcat = new docman.Classes.Categories();
        Categories cat = new Categories();
        public CreateNewCategory()
        {
            InitializeComponent();
        }

        public CreateNewCategory(Categories cat)
        {
            InitializeComponent();
            this.cat = cat;
        }

        private void CreateNewCategory_Load(object sender, EventArgs e)
        {
          
            newMain.customToCat(staff);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String namecat = name.Text;
            String staffcat = staff.SelectedValue.ToString();
            newcat.newMainCategory(namecat,staffcat);
            cat.formReload();
            this.Close();
        }
    }
}
