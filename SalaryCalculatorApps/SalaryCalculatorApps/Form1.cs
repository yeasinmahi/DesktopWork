using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApps
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }
        Salary aSalary = new Salary();

       
     public void showButton_Click(object sender, EventArgs e)
        {
            

            aSalary.employeeName = employeeNameTextBox.Text;
            aSalary.basicAmount = Convert.ToDouble(basicAmoutTextBox.Text);
            aSalary.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowance = Convert.ToDouble(medicalTextBox.Text);
              aSalary.GetHouseRent();
              aSalary.GetMedicalAllowance();
            MessageBox.Show(aSalary.employeeName + " your salary is: " + aSalary.TotalSalaryCal());
        }
    }
}
