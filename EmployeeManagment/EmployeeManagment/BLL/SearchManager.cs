using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.DAL;
using EmployeeManagment.model;

namespace EmployeeManagment.BLL
{
    class SearchManager
    {
        SearchGatway searchGatway = new SearchGatway();

        public List<Employee> LoadAllEmployees()
        {
            return searchGatway.LoadAllEmployees();
        }

        public List<Employee> SearchEmployees(string name)
        {
            return searchGatway.SearchEmployees(name);
        }
    }
}
