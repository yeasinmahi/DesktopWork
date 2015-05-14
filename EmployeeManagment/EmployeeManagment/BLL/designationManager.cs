using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.DAL;
using EmployeeManagment.model;

namespace EmployeeManagment.BLL
{
    class DesignationManager
    {
        DesignationGatway designationGatway = new DesignationGatway();
        public bool Insert(Designation designation)
        {
            return designationGatway.Insert(designation) > 0;
        }
    }
}
