using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private double _firstNumber = 0;
        private double _secondNumber = 0;
        readonly calculator cal = new calculator();
        public Calculator()
        {
            InitializeComponent();
        }

        private void SetValue()
        {
            _firstNumber = Convert.ToDouble(FirstTextBox.Text);
            _secondNumber = Convert.ToDouble(secondTextBox.Text);
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            SetValue();
            resultTextBox.Text = ""+(cal.Addition(_firstNumber,_secondNumber));
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            SetValue();
            resultTextBox.Text = "" + (cal.Substruction(_firstNumber, _secondNumber));
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            SetValue();
            resultTextBox.Text = "" + (cal.Multification(_firstNumber, _secondNumber));
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            SetValue();
            resultTextBox.Text = "" + (cal.Division(_firstNumber, _secondNumber));
        }
    }
}
