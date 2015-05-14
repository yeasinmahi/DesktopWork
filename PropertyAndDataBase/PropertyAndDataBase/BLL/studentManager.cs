using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyAndDataBase.DAL;
using PropertyAndDataBase.Model;

namespace PropertyAndDataBase.BLL
{
    class StudentManager
    {
        StudentGatway studentGatway = new StudentGatway();
        public bool Insert(Student aStudent)
        {
            return studentGatway.Insert(aStudent)>0;
        }

        public List<Student> ListViewAll()
        {
            return studentGatway.ListViewStudents();
        }
        public List<Student> SearchStudents(string name)
        {
            return studentGatway.SearchStudents(name);
        }

        public bool Update(Student aStudent, Student updateableStudent)
        {
            return studentGatway.Update(aStudent,updateableStudent) > 0;
        }

        public bool Delete(Student aStudent)
        {
            return studentGatway.Delete(aStudent) > 0;
        }
    }
}
