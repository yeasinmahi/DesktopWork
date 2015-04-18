using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01Part2
{
    class Greeting
    {
        public void greeting()
        {
            Console.Write("Enter your name Please ");
            string name=Console.ReadLine();
            Console.WriteLine("Hi, "+name+".\n\t Have a nice day.");
        }
    }
}
