using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using dbEmployeeInfoSave.Model;

namespace dbEmployeeInfoSave.DAL
{
    class DbConnector
    {
        //private string connectionString = @"server=.\SQLEXPRESS; database=employee; integrated security=true;";
        private string connectionString = ConfigurationManager.ConnectionStrings["empConnection"].ConnectionString;
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
            return false;
        }

        public List<EmployeeInfo> SearchByName(string name)
        {
            string query = "select * from [emp] where [name] like '%"+name+"%'";
            return GiveEmpInfo(query);
        }

        public List<EmployeeInfo> LoadAllEmp()
        {
            string query = "select * from [emp]";
            return GiveEmpInfo(query);
        }

        private List<EmployeeInfo> GiveEmpInfo(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            List<EmployeeInfo> employeeList = new List<EmployeeInfo>();

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    EmployeeInfo emp = new EmployeeInfo();
                    emp.id = Convert.ToInt32(reader["id"].ToString());
                    emp.name = reader["name"].ToString();
                    emp.email = reader["email"].ToString();
                    emp.address = reader["address"].ToString();
                    emp.salary = Convert.ToDouble(reader["salary"].ToString());
                    employeeList.Add(emp);
                }
            }
            connection.Close();
            return employeeList;
        }
    }
}
