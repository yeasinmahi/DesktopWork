using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01
{
    class NaturalNumberDifferent
    {
        public void NaturalNumber()
        {
            Int64 firstNumber = 0, secondNumber = 0, result = 0;
            for (int i = 1; i <= 100; i++)
            {
                firstNumber += i*i;
                secondNumber += i;
            }
            secondNumber *= secondNumber;
            result = secondNumber-firstNumber;
            Console.WriteLine("Sum of Square: " + firstNumber);
            Console.WriteLine("Square of Sum: " + secondNumber);
            Console.WriteLine("Your Desire number is: "+result);

        }
    }
}
