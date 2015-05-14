using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.DAL;
using EmployeeManagment.model;

namespace EmployeeManagment.BLL
{
    class EmployeeManager
    {
        EmployeeGatway employeeGatway = new EmployeeGatway();
        public List<Designation> ComboBoxDesignationsList()
        {
            return employeeGatway.ComboBoxDesignationsList();
        }

        public bool Insert(Employee employee)
        {
            return employeeGatway.Insert(employee) > 0;
        }
    }
}
