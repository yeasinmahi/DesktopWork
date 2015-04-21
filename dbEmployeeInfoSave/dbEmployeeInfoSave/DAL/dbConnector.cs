using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dbEmployeeInfoSave.Model;

namespace dbEmployeeInfoSave
{
    class dbConnector
    {
        private string connectionString = @"server=.\SQLEXPRESS; database=employee; integrated security=true;";

        public bool InsertData(EmployeeInfo emp)
        {
            string query = "insert into [emp] ([name],[email],[address],[salary]) values ('"+emp.name+"','"+emp.email+"','"+emp.address+"',"+emp.salary+")";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int check=command.ExecuteNonQuery();
            connection.Close();
            if (check>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
