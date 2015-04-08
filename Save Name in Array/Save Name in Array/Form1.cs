using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Save_Name_in_Array
{
    public partial class Form1 : Form
    {
        private List<string> name= new List<string>();
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void showAll()
        {
            nameListBox.Items.Clear();
            foreach (string s in name)
            {
                nameListBox.Items.Add(s);

            }
            totalTextBox.Text = counter.ToString();
        }
        private void save()
        {
            if (counter<5)
            {
                name.Add(nameTextBox.Text);
                counter++;
                MessageBox.Show("Successfuly Saved");
            }
            else
            {
                MessageBox.Show("You can save only 5 name");
            }
            
        }

        private void clear()
        {
            nameTextBox.Text = String.Empty;

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
            clear();

        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            showAll();
        }
    }
}
