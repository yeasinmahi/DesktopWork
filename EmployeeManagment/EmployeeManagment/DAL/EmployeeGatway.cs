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
    class EmployeeGatway
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        
        public List<Designation> ComboBoxDesignationsList()
        {
            List<Designation> listDesignations= new List<Designation>();
            string query = "select * from designation";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Designation designation = new Designation();
                designation.desId = reader["desId"].ToString();
                designation.code = reader["code"].ToString();
                designation.title = reader["title"].ToString();
                listDesignations.Add(designation);
            }
            connection.Close();
            return listDesignations;
        }

        public int Insert(Employee employee)
        {
            string query = "insert into employee (name, email, address, desId) values ('" + employee.Name + "','" + employee.Email + "','" + employee.Address + "','" + employee.DesId + "')";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
