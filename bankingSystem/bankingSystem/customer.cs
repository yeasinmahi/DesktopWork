using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankingSystem
{
    class Customer
    {
        private string accountNumber;
        private string customerName;
        private double amount;

        public void CreateAccount(string accountNum, string customerNam)
        {
            this.accountNumber = accountNum;
            this.customerName = customerNam;
            this.amount = 0;
            MessageBox.Show("Account Created Successfully");
        }

        public void Deposite(double depositeAmount)
        {
            amount += depositeAmount;
            MessageBox.Show("Successfuly Deposite");
        }

        public void Widrow(double widrowAmount)
        {
            if (widrowAmount>amount)
            {
                MessageBox.Show("You cannot widrow "+widrowAmount+" taka, you have only "+amount+" taka in your account.");
            }
            else
            {
                amount -= widrowAmount;
                MessageBox.Show("Successfuly Widrowed");
            }
        }

        public void Report()
        {
            MessageBox.Show("Account Number: "+accountNumber+"\nCustomer Name: "+customerName+"\nTotal Amount :"+amount);
        }

    }
}
