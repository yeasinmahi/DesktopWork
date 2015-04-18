using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    class employee
    {
        public string id="";
        public string name="";
        public string salary="";

        public string ShowMessage()
        {
            return "ID: " + id + "\nNmae: " + name + "\nSalary: " + salary;
        }
    }
}
