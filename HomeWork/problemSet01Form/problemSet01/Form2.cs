using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSet01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void form(int question)
        {
            pictureBox1.Visible = false;
            switch (question)
            {

                case 1:
                    label1.Text = "1) Take upper and lower limit from user and show all integers between them (including them). ";
                    break;
                case 2:
                    label1.Text = "2) Show all even number from 1 to 100 ";
                    break;
                case 3:
                    label1.Text =
                        "3) If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. ";
                    label1.Text += "Find the sum of all the multiples of 3 or 5 below 1000. ";
                    break;
                case 4:
                    label1.Text = "4) The sum of the squares of the first ten natural numbers is ";
                    label1.Text += "12 + 22 + ... + 102 = 385 ";
                    label1.Text += "The square of the sum of the first ten natural numbers is, ";
                    label1.Text += "(1 + 2 + ... + 10)2 = 552 = 3025 ";
                    label1.Text += "Hence the difference between the sum of the squares of the first ten natural numbers ";
                    label1.Text += "and the square of the sum is 3025 − 385 = 2640. ";
                    label1.Text += "Find the difference between the sum of the squares of the first one hundred natural ";
                    label1.Text += "numbers and the square of the sum. ";
                    break;
                case 5:
                    label1.Text = "Md. Yeasin Arafat";
                    pictureBox1.Visible = true;
                    break;
                default:
                    pictureBox1.Visible = false;
                    label1.Text = "No quession can shown right now";
                    break;
            }
            ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
