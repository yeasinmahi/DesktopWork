using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01
{
    class EvenNumber
    {
        public void EvenNum()
        {
            Console.WriteLine("All Even Numbers between 1-100 are:");
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    Console.Write(" "+i);
                }
            }
        }
    }
}
