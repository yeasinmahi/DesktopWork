using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbEmployeeInfoSave.Model;

namespace dbEmployeeInfoSave.BLL
{
    class EmpManager
    {
        dbConnector connector = new dbConnector();
        public string Insert(EmployeeInfo employee)
        {
            if (connector.InsertData(employee))
            {
                return "Saved Successfuly";
            }
            else
            {
                return "A problem Occured in insert";
            }
            
        }
    }
}
