using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculate
{
    public partial class Form1 : Form
    {
        private string _name;
        private double _basicSalary;
        private double _houseRent;
        private double _medicalAllowence;
        private double _houseRentPercentage;
        private double _medicalAllowencePercentage;

        Salary salary= new Salary();
        public Form1()
        {
            InitializeComponent();
        }

        private void SetValue()
        {
            _name = nameTextBox.Text;
            _basicSalary = Convert.ToDouble(basicSalaryTextBox.Text);
            _houseRentPercentage = Convert.ToDouble(houseRentTextBox.Text);
            _medicalAllowencePercentage = Convert.ToDouble(medicalAllowenceTextBox.Text);
        }

        private void salaryCalculateButton_Click(object sender, EventArgs e)
        {
            SetValue();
            _houseRent = salary.CalculateHousRent(_basicSalary, _houseRentPercentage);
            _medicalAllowence = salary.CalculateMedicalAllowence(_basicSalary, _medicalAllowencePercentage);
            double totalSalary = salary.CalculateTotalSalary(_basicSalary, _houseRent, _medicalAllowence);
            MessageBox.Show("Name: " + _name + "\nHouse Rent: " + _houseRent + "\nMedical Allowence: " +
                            _medicalAllowence + "\nTotal Salary: " + totalSalary);
        }
    }
}
