using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using FareManagement.Model;

namespace FareManagement.DAL
{
    class LoadGatway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public List<Zone> LoadAllZone()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from zone";
            SqlCommand commnd = new SqlCommand(query,connection);
            List<Zone> listZones=new List<Zone>();
            connection.Open();
            SqlDataReader reader = commnd.ExecuteReader();

            while (reader.Read())
            {
                Zone zone = new Zone();
                zone.ZoneId = Convert.ToInt32(reader["zid"].ToString());
                zone.ZoneName = reader["zoneName"].ToString();
                listZones.Add(zone);
            }
            connection.Close();
            return listZones;
        }
        public List<Visitor> LoadAllVisitorList(int zid)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            List<Visitor> visitors= new List<Visitor>();
            command.Connection = connection;
            command.CommandType=CommandType.StoredProcedure;
            command.CommandText = "visitorListByZoneId";
            command.Parameters.Add(new SqlParameter("@zid", SqlDbType.Int)).Value = zid;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Visitor visitor = new Visitor();
                visitor.Name = reader["name"].ToString();
                visitor.Email = reader["email"].ToString();
                visitor.Contact = reader["contact"].ToString();
                visitors.Add(visitor);
            }
            connection.Close();
            return visitors;
        }

        
        public List<ZoneWiseVisitor> LoadZoneWiseVisitors()
        {
            int totalVIsitor = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from ZoneWiseVisitor";
            SqlCommand commnd = new SqlCommand(query, connection);
            List<ZoneWiseVisitor> zoneWiseVisitors = new List<ZoneWiseVisitor>();
            connection.Open();
            SqlDataReader reader = commnd.ExecuteReader();
            while (reader.Read())
            {
                ZoneWiseVisitor zoneWiseVisitor = new ZoneWiseVisitor();
                zoneWiseVisitor.ZoneName = reader[0].ToString();
                zoneWiseVisitor.TotalVisitor = reader[1].ToString();
                zoneWiseVisitors.Add(zoneWiseVisitor);
                totalVIsitor += Convert.ToInt32(zoneWiseVisitor.TotalVisitor);
            }
            connection.Close();
            TotalVisitors = totalVIsitor;
            return zoneWiseVisitors;
        }

        private int TotalVisitors { get; set; }
        public string TotalVisitor()
        {
            return TotalVisitors.ToString(CultureInfo.InvariantCulture);
        }
    }
}
