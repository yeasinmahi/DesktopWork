using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApps
{
        
    class Salary
    {
        public string employeeName;
        public double basicAmount;
        public double houseRent;
        public double medicalAllowance;

        public double totalSalary;

        public double GetHouseRent()
        {
            houseRent = (basicAmount *( (houseRent) / 100));
            return houseRent;
        }

        public double GetMedicalAllowance()
        {

            medicalAllowance = (basicAmount*((medicalAllowance)/100));
            return medicalAllowance;
        }
        
        public double TotalSalaryCal()
        {

            totalSalary = basicAmount + houseRent + medicalAllowance;
            return totalSalary;



        }
    }
}
