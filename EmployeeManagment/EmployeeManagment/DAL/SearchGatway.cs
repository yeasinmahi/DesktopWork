using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagment.model;

namespace EmployeeManagment.DAL
{
    class SearchGatway
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public List<Employee> LoadAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>();
            string query = "select * from employee";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Name = reader["name"].ToString();
                employee.Email = reader["email"].ToString();
                employee.Address = reader["address"].ToString();
                listEmployees.Add(employee);
            }
            connection.Close();
            return listEmployees;
        }

        public List<Employee> SearchEmployees(string name)
        {
            List<Employee> listEmployees = new List<Employee>();
            string query = "select * from employee where name like '%"+name+"%'";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Name = reader["name"].ToString();
                employee.Email = reader["email"].ToString();
                employee.Address = reader["address"].ToString();
                listEmployees.Add(employee);
            }
            connection.Close();
            return listEmployees;
        }
    }
}
