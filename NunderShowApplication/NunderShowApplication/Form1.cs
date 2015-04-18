using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NunderShowApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showNumberListBox.Items.Clear();
            string number = showNumberTextBox.Text;
            int number1 = Convert.ToInt32(number);
            double sum = 0;

            for (int i = 0; i <= number1; i++)
            {
                showNumberListBox.Items.Add(i.ToString());
                sum = sum + i;
            }
            showNumberListBox.Items.Add("Sum Is: "+sum.ToString());
            MessageBox.Show(showNumberListBox.SelectedItems.ToString());
        }

    }
}
