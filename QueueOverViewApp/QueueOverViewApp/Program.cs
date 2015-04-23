


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOverViewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // first in first out
            Queue<String> aQueue = new Queue<string>();

            aQueue.Enqueue("Hello");
            aQueue.Enqueue("Arafat");
            aQueue.Enqueue("Yeasin");


            aQueue.Dequeue(); // Pop up the first i input in queue

            Console.WriteLine(aQueue.Peek()); // return the last popable value
            foreach (string s in aQueue)
            {
                Console.WriteLine(s);
            }
        }
    }
}
