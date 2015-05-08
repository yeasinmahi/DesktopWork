using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInfo.Model;

namespace ProductInfo.DAL
{
    class ProductGatway
    {
        readonly string _connectionStrng = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        public int Insert(Product product)
        {
            string query = "insert into product (code,des,quantity) values ('" + product.Code + "','" + product.Description + "'," + product.Quantity + ")";
            SqlConnection connection = new SqlConnection(_connectionStrng);
            SqlCommand command= new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public bool IsCode(Product product)
        {
            string query = "select * from product where code='"+product.Code+"'";
            SqlConnection connection = new SqlConnection(_connectionStrng);
            SqlCommand command = new SqlCommand(query, connection);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public int Update(Product product)
        {
            string query = "update product set des='" + product.Description + "', quantity=" + product.Quantity + " where code='"+product.Code+"'";
            SqlConnection connection = new SqlConnection(_connectionStrng);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Product> LoadAllPoduct()
        {
            List<Product> listpProducts= new List<Product>();
            string query = "select * from product";
            SqlConnection connection = new SqlConnection(_connectionStrng);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product= new Product();
                    product.Code = reader["code"].ToString();
                    product.Description = reader["des"].ToString();
                    product.Quantity = Convert.ToInt32(reader["quantity"].ToString());
                    listpProducts.Add(product);
                }
            }
            connection.Close();
            return listpProducts;
        }

        public int TotalQuantity()
        {
            string query = "select * from product";
            SqlConnection connection = new SqlConnection(_connectionStrng);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int quantity = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quantity += Convert.ToInt32(reader["quantity"].ToString());
                }
            }
            connection.Close();
            return quantity;
        }
    }
}
