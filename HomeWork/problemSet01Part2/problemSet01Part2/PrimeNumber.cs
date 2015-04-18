using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01Part2
{
    class PrimeNumber
    {
        public void primeNumber()
        {
            Console.WriteLine("Enter a integer value, i will say it is prime number or not.");
            string inputNumber=Console.ReadLine();
            int PrimeNumber = 0;
            if (int.TryParse(inputNumber, out PrimeNumber))
            {
                int upperValueOfLoop = PrimeNumber/2;
                bool check = true;
                if (PrimeNumber==1)
                {
                    Console.WriteLine(PrimeNumber + " is a Prime Number");
                }
                else
                {
                    for (int i = 2; i < upperValueOfLoop; i++)
                    {
                        if (PrimeNumber % i == 0)
                        {
                            check = false;
                            //break;

                        }
                    }
                    if (check)
                    {
                        Console.WriteLine(PrimeNumber + " is a Prime Number");
                    }
                    else
                    {
                        Console.WriteLine(PrimeNumber + " is Not a Prime Number");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Please Enter A valid Natural Number");
            }

        }
    }
}
