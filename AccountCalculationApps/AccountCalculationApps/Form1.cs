using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountCalculationApps
{
    public partial class AcountOperationUI : Form
    {
        public AcountOperationUI()
        {
            InitializeComponent();
        }
        Account account = new Account();
        public void createButton_Click(object sender, EventArgs e)
        {
           

            account.accountNumber = accountNumberTextBox.Text;
            account.customerName = customerNameTextBox.Text;
            MessageBox.Show("Saved");
            accountNumberTextBox.Text = "";
            customerNameTextBox.Text = "";

        }

        public void depositButton_Click(object sender, EventArgs e)
        {
            //double totalSaveAmount;
            account.aDeposit = Convert.ToDouble(amountTextBox.Text);
            account.totalSaveAmount = account.totalSaveAmount + account.aDeposit;
            MessageBox.Show("Saved Amount");
            amountTextBox.Text = "";
        }

        public void withdrawButton_Click(object sender, EventArgs e)
        {
           // double totalBalance;
            account.aWithdraw = Convert.ToDouble(amountTextBox.Text);
            account.accountWidthdraw = account.accountWidthdraw + account.aWithdraw;
            account.totalBalance = account.GetNetBlance();
            MessageBox.Show("total balance after withdraw:" +account.totalBalance);
            amountTextBox.Text = "";
        }

        public void reportButton_Click(object sender, EventArgs e)
        {
           // account.accountNumber = accountNumberTextBox.Text;
            //account.customerName = customerNameTextBox.Text;

            MessageBox.Show(account.customerName +
                ", your account number is: " + account.accountNumber + " and it's balance is:" + account.totalBalance);
        }
    }
}
