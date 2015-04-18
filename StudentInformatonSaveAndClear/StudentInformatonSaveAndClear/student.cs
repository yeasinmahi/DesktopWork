using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformatonSaveAndClear
{
    class student
    {
        public string regNo;
        public string fname;
        public string lname;

        public string GetFullName()
        {

            return fname + " " + lname;
        }
    }
}
