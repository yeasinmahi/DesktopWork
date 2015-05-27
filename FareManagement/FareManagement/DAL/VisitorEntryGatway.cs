using System;
using System.Configuration;
using System.Data.SqlClient;
using FareManagement.Model;

namespace FareManagement.DAL
{
    class VisitorEntryGatway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public int InsertVisitor(Visitor visitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into visitor (name,email,contact) values ('" + visitor.Name + "','" + visitor.Email + "','" + visitor.Contact + "')";
            SqlCommand commnd = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = commnd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool HasEmail(Visitor visitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select vid from visitor where email='" + visitor.Email + "'";
            SqlCommand commnd = new SqlCommand(query, connection);
            int vid = 0;
            connection.Open();
            SqlDataReader reader = commnd.ExecuteReader();
            if (reader.HasRows)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;

        }
        public int GetVisitorIdByEmail(Visitor visitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select vid from visitor where email='"+visitor.Email+"'";
            SqlCommand commnd = new SqlCommand(query, connection);
            int vid = 0;
            connection.Open();
            SqlDataReader reader = commnd.ExecuteReader();
            while (reader.Read())
            {
                vid = Convert.ToInt32(reader["vid"].ToString());
            }
            connection.Close();
            return vid;
        }

        public int InsertVisitorAndZone(VisitorAndZone visitorAndZone)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "insert into visitorAndZone (vid,zid) values ('" + visitorAndZone.VisitorId + "','" + visitorAndZone.ZoneId + "')";
            SqlCommand commnd = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = commnd.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
