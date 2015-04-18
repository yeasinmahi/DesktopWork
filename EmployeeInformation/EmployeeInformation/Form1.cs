using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class Form1 : Form
    {
        employee aEmployee = new employee();
        public Form1()
        {
            InitializeComponent();
        }

        private void SetValue()
        {
            aEmployee.id = idTextBox.Text;
            aEmployee.name = nameTextBox.Text;
            aEmployee.salary = salaryTextBox.Text;
        }

        private void DoClear()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void RetriveValue()
        {
            idTextBox.Text = aEmployee.id;
            nameTextBox.Text = aEmployee.name;
            salaryTextBox.Text = aEmployee.salary;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SetValue();
            MessageBox.Show(aEmployee.ShowMessage());
            DoClear();
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            RetriveValue();
        }
    }
}
