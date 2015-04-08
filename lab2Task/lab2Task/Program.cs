using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int result=0;
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in array)
            {
                result += i;
            }
            Console.WriteLine("Total: "+result);
        }
    }
}
