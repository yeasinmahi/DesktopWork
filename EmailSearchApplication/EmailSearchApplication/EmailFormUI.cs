using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailSearchApplication
{
    public partial class EmailF : Form
    {
        public EmailF()
        {
            InitializeComponent();
        }

        private List<string> addEmailList = new List<string>();

        private void emailAddButton_Click(object sender, EventArgs e)
        {
            addEmailList.Add(emailAddTextBox.Text);
            if (emailAddTextBox.Text.Contains("@") && emailAddTextBox.Text.Contains("."))
          
            emailAddListBox.Items.Add(addEmailList);

           
        }

        private void emailSearchButton_Click(object sender, EventArgs e)
        {
            List<string> searchEmailList = new List<string>();
            searchEmailList.Add(emailSearchTextBox.Text);

            if (addEmailList == searchEmailList)
            {
                emailSearchListBox.Items.Add(addEmailList);
            }
        }
    }
}
