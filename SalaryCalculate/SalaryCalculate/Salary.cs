using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculate
{
    class Salary
    {
        public double CalculateHousRent(double basicSalary, double houseRent)
        {
            return basicSalary*houseRent/100;
        }
        public double CalculateMedicalAllowence(double basicSalary, double medicalAllowence)
        {
            return basicSalary * medicalAllowence / 100;
        }
        public double CalculateTotalSalary(double basicSalary, double houseRent, double medicalAlloence)
        {
            return basicSalary + houseRent + medicalAlloence;
        }
    }
}
