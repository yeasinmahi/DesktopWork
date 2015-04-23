using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Customer _customer = new Customer();
        private void createButton_Click(object sender, EventArgs e)
        {
            _customer.CreateAccount(accountNumberTextBox.Text,customerNameTextBox.Text);
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            _customer.Deposite(Convert.ToDouble(amountTextBox.Text));
        }

        private void widrowButton_Click(object sender, EventArgs e)
        {
            _customer.Widrow(Convert.ToDouble(amountTextBox.Text));
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            _customer.Report();
        }
    }
}
