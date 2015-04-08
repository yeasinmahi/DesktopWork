using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listView
{
    public partial class Form1 : Form
    {
        private int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            inputListView.Items.Clear();
            number = Convert.ToInt32(inputTextBox.Text);
            for (int i=0;i<=number;i++)
            {
                inputListView.Items.Add(i.ToString());
                //inputListBox.Items.Add(i.ToString());
            }
        }
    }
}
