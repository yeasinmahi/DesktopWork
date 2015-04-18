using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01Part2
{
    class Circle
    {
        const double pi = Math.PI;
        public void circle()
        {
            Console.WriteLine("Enter the radious of a circle ");
            double radious = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Circle Area is "+pi*radious*radious);
        }
    }
}
