using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01
{
    class UpperLower
    {
        public void UpperLowerLimit()
        {
            int upper = 0, lower = 0;
            Console.Write("Lower Value: ");
            if (int.TryParse(Console.ReadLine(), out lower))
            {
                Console.Write("Upper Value: ");
                if (int.TryParse(Console.ReadLine(), out upper))
                {
                    Console.Write("From "+lower+" to "+upper+ " values: ");
                    for (int i=lower;i<=upper;i++)
                    {
                        Console.Write(" "+i);
                    }
                }
                else
                {
                    Console.WriteLine("Enter proper integer");
                }
            }
            else
            {
                Console.WriteLine("Enter proper integer");
            }
            
            
        }
    }
}
