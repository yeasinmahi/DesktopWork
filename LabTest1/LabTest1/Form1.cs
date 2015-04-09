using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTest1
{
    public partial class Form1 : Form
    {
        private double PrincipleAmount = 0;
        private double InterestValue = 0;
        private double CompundInterest = 0;
        private double YearToGrow = 0;
        private double FutureTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void SetValue()
        {
            PrincipleAmount = Convert.ToDouble(principalAmountTextBox.Text);
            InterestValue = Convert.ToDouble(interestRateTextBox.Text);
            CompundInterest = Convert.ToDouble(compoundInterestTextBox.Text);
            YearToGrow = Convert.ToDouble(yearToGrowTextBox.Text);
        }

        private void Calculate()
        {
            FutureTotal = PrincipleAmount*(Math.Pow((1 + (InterestValue/CompundInterest/100)), (CompundInterest*YearToGrow)));
            futureTotalTextBox.Text = FutureTotal.ToString();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            SetValue();
            Calculate();
        }
    }
}
