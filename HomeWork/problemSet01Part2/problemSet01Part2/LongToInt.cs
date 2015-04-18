using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01Part2
{
    class LongToInt
    {
        public void LongInt()
        {
            Console.Write("Enter Long Value ");
            string inputNumber = Console.ReadLine();
            Int64 LongNumber=0;
            if (Int64.TryParse(inputNumber, out LongNumber))
            {
                int number = (int) LongNumber;
                Console.WriteLine("Integer Value "+number);
            }
            else
            {
                Console.WriteLine("Enter Integer Number");
            }

        }
        
    }
}
