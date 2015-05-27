using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FareManagement.Model;

namespace FareManagement.DAL
{
    class ZoneTypeGatway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public int InsertZone(string zoneName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into zone (zoneName) values ('"+zoneName+"')";
            SqlCommand commnd = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = commnd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
