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
        List<EmployeeInfo> employeeList= new List<EmployeeInfo>(); 
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

        public void SearchByName(string name)
        {
            string query = "select * from [emp] where [name] like %"+name+"%";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                
            }
            else
            {
                
            }
            connection.Close();
        }

        public List<EmployeeInfo> LoadAllEmp()
        {
            string query = "select * from [emp]";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EmployeeInfo emp= new EmployeeInfo();
                    emp.name = reader["name"].ToString();
                    emp.email = reader["email"].ToString();
                    emp.address = reader["address"].ToString();
                    emp.salary = Convert.ToDouble(reader["salary"].ToString());
                    employeeList.Add(emp);
                }
            }
            else
            {

            }
            connection.Close();
            return employeeList;
        }
        //private void 
    }
}
