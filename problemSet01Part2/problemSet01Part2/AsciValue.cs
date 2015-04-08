using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01Part2
{
    class AsciValue
    {
        public void asciValue()
        {
            Console.WriteLine("Enter a Chatecter and i will show you the ASCII value");
            char value=Convert.ToChar(value: Console.ReadLine());
            Console.WriteLine(Convert.ToInt32(value));
        }
    }
}
