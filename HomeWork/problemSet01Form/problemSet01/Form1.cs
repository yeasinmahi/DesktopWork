using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemSet01
{
    public partial class Form1 : Form
    {
        private Form2 form2=new Form2();
        private UpperLower ul;
        private EvenNumber en;
        private DivisorOf3and5 divisor;
        private NaturalNumberDifferent naturalNumber;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            ul = new UpperLower();
            en = new EvenNumber();
            divisor = new DivisorOf3and5();
            naturalNumber = new NaturalNumberDifferent();
            panel1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item=comboBox1.SelectedIndex;
            switch (item)
            {
                case 1:
                    panel1.Visible = true;
                    formControl(1);
                    break;
                case 2:
                    panel1.Visible = false;
                    en.EvenNum(ans);
                    formControl(2);
                    break;
                case 3:
                    panel1.Visible = false;
                    divisor.Divisor(ans);
                    formControl(3);
                    break;
                case 4:
                    panel1.Visible = false;
                    naturalNumber.NaturalNumber(ans);
                    formControl(4);
                    break;
                case 5:
                    panel1.Visible = false;
                    Application.Exit();
                    break;
                default:
                    panel1.Visible = false;
                    ans.Text= "Select The Question";
                    break;
            }
            ;
            
        }

        private void UpDown()
        {
            int lower = 0;
            int upper = 0;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                
                if (int.TryParse(textBox1.Text, out lower))
                {
                    if (int.TryParse(textBox2.Text, out upper))
                    {
                        ul.UpperLowerLimit(lower, upper, ans);
                    }
                    else
                    {
                        ans.Text = "Enter number in Upper box";
                    }
                }
                else
                {
                    ans.Text = "Enter number in Lower box";
                }
                
            }
            else
            {
                ans.Text = "Enter Limit value";
            }
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            UpDown();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formControl(5);
        }

        private void upperAndLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formControl(1);
        }

        private void evenNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formControl(2);
        }

        private void divisorOf3And5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formControl(3);
        }

        private void naturalNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formControl(4);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formControl(int i)
        {
            if (form2.IsDisposed)
            {
                form2 = new Form2();
                
            }
            form2.form(i);
            form2.Show();
        }
    }
}
