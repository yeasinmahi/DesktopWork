using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculate
{
    public partial class interestCalculator : Form
    {
        private double interest = 0;
        private double Balance = 0;
        private int time = 0;

        public interestCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Balance = Convert.ToDouble(balanceTextBox.Text);
            time = Convert.ToInt32(timeTextBox.Text);
            
            switch (bankComboBox.SelectedIndex)
            {
                
                case 0:
                    interest = calculate(Balance, time, .06);
                    break;
                case 1:
                    interest = calculate(Balance, time, .07);
                    break;
                case 2:
                    interest = calculate(Balance, time, .08);
                    break;
                    
            }
            interestLabel.Text = "interest= "+interest;
        }

        private double calculate(double balance, int year, double persantage)
        {
            return balance*year*persantage;
        }
    }
}
