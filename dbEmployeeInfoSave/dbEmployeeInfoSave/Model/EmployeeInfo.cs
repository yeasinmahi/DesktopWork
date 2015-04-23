using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEmployeeInfoSave.Model
{
    public class EmployeeInfo
    {
        public int id;
        public string name;
        public string email;
        public string address;
        public double salary;

        public void SetValue(string name, string email, string address, double salary)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.salary = salary;
        }
    }
}
