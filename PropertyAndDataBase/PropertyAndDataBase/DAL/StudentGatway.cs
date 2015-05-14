using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyAndDataBase.Model;

namespace PropertyAndDataBase.DAL
{
    class StudentGatway
    {
        private string conectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public int Insert(Student aStudent)
        {
            int isExecute=0;
            string query = "insert into student (name,email,cgpa) values ('"+aStudent.Name+"','"+aStudent.Email+"','"+aStudent.Cgpa+"')";

            try
            {
                SqlConnection connection = new SqlConnection(conectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                isExecute = command.ExecuteNonQuery();
                connection.Close();
                return isExecute;
            }
            catch (Exception exception)
            {

                return isExecute;
            }
        }

        public List<Student> ListViewStudents()
        {
            string query = "select * from student";
            List<Student> listStudents= new List<Student>();
            try
            {
                SqlConnection connection=new SqlConnection(conectionString);
                SqlCommand command= new SqlCommand(query,connection);
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader["id"].ToString());
                    student.Name = reader["name"].ToString();
                    student.Email = reader["email"].ToString();
                    student.Cgpa = Convert.ToDouble(reader["cgpa"].ToString());
                    listStudents.Add(student);
                }
                connection.Close();
                return listStudents;
            }
            catch (Exception exception)
            {
                return listStudents;
            }
        }

        public List<Student> SearchStudents( string  name)
        {
            string query = "select * from student where name like '%"+name+"%'";
            List<Student> listStudents = new List<Student>();
            try
            {
                SqlConnection connection = new SqlConnection(conectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader["id"].ToString());
                    student.Name = reader["name"].ToString();
                    student.Email = reader["email"].ToString();
                    student.Cgpa = Convert.ToDouble(reader["cgpa"].ToString());
                    listStudents.Add(student);
                }
                connection.Close();
                return listStudents;
            }
            catch (Exception exception)
            {
                return listStudents;
            }
        }

        public int Update(Student aStudent, Student updateableStudent)
        {
            int isExecute = 0;
            string query = "update student set name='" + aStudent.Name + "', email='" + aStudent.Email + "', cgpa='" + aStudent.Cgpa + "' where name='" + updateableStudent.Name + "' and email='" + updateableStudent.Email + "' and cgpa='" + updateableStudent.Cgpa + "'";
            
            try
            {
                SqlConnection connection = new SqlConnection(conectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                isExecute = command.ExecuteNonQuery();
                connection.Close();
                return isExecute;
            }
            catch (Exception exception)
            {

                return isExecute;
            }
        }

        public int Delete(Student aStudent)
        {
            int isExecute = 0;
            string query = "delete student where name='" + aStudent.Name + "' and email='" + aStudent.Email + "' and cgpa='" + aStudent.Cgpa + "'";

            try
            {
                SqlConnection connection = new SqlConnection(conectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                isExecute = command.ExecuteNonQuery();
                connection.Close();
                return isExecute;
            }
            catch (Exception exception)
            {

                return isExecute;
            };
        }
    }
}
