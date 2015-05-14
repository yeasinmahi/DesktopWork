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
    
    class DesignationGatway
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public int Insert(Designation designation)
        {
            string query = "insert into designation (code, title) values ('"+designation.code+"','"+designation.title+"')";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
