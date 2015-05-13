using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfStudentsApp
{
    class Student
    {
        public string regNo ;
        public string firstName ;
        public string lastName ;

        public string GetFirstNAndLastName()
        {
            return firstName + " " + lastName;
        }

    }
}
