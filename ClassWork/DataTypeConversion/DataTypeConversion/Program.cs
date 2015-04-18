using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 20;
            // implicive conversion
            double secondNumber = firstNumber;  
            Console.WriteLine(secondNumber);

            // explicive Conversion
            int thirdNumber = (int) secondNumber;
            Console.WriteLine(thirdNumber);

            int key = 65;
            Console.WriteLine(Convert.ToChar(key));

            char charecter = 'H';
            Console.WriteLine(Convert.ToInt16(charecter));
            int with=Console.LargestWindowWidth;
            Console.WriteLine(with);
            for (Int64 i = 0; i < 290; i++)
            {
                Console.WriteLine("ASCI value= "+i+"="+Convert.ToChar(i));
            }
        }
    }
}
