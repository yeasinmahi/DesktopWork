using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketNamePrice
{
    public partial class Form1 : Form
    {
        private string customerName = "Undifined";
        private int totalPrice = 0;
        private int numberOfTicket = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void setValue()
        {
            if (nameTextBox.Text != "" && ticketNumberTextBox.Text != "")
            {
                customerName = nameTextBox.Text;
                numberOfTicket = Convert.ToInt32(ticketNumberTextBox.Text);
                totalPrice = 10 * numberOfTicket;
            }
            
        }

        private void clear()
        {
            nameTextBox.Text = "";
            ticketNumberTextBox.Text = "";
        }
        private void totalButton_Click(object sender, EventArgs e)
        {
            setValue();
            MessageBox.Show(""+customerName+", have to pay "+totalPrice+" taka");
            clear();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            setValue();
            MessageBox.Show("Customer Name: "+customerName+"\nPrice Of Per Ticket: 10 Taka\n Total Amount: "+totalPrice);
            clear();
        }
    }
}
