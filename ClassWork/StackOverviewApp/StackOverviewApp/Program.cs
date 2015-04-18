using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverviewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> aStack=new Stack<int>();
            aStack.Push(101);
            aStack.Push(251);
            aStack.Push(315);

            aStack.Pop();// It pop out the last value i input
            Console.WriteLine(aStack.Peek());  // It show the last value which can be pop right now

            foreach (int i in aStack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
