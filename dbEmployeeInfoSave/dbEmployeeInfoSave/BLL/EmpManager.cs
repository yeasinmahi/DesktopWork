using System.Collections.Generic;
using dbEmployeeInfoSave.DAL;
using dbEmployeeInfoSave.Model;

namespace dbEmployeeInfoSave.BLL
{
    class EmpManager
    {
        DbConnector connector = new DbConnector();
        public string Insert(EmployeeInfo employee)
        {
            if (connector.InsertData(employee))
            {
                return "Saved Successfuly";
            }
            return "A problem Occured in insert";
        }

        public List<EmployeeInfo> Search(string name)
        {
            return connector.SearchByName(name);
        }

        public List<EmployeeInfo> LoadAllEmp()
        {
            return connector.LoadAllEmp();
        } 
    }
}
