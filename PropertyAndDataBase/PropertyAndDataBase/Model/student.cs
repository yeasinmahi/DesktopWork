using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAndDataBase.Model
{
    class Student
    {
        private int id;
        private string name;
        private string email;
        private double cgpa;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
    }
}
