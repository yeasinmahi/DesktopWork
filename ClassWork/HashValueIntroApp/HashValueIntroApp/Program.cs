using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashValueIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable= new Hashtable();

            aHashtable.Add(101,101014);
            aHashtable.Add("key","Yeasin");
            aHashtable.Add("ID", 182791);
            aHashtable.Add(111, "WOrld");

            Console.WriteLine(aHashtable.ContainsValue(101));     // false
            Console.WriteLine(aHashtable.ContainsValue(101014));  // true
            Console.WriteLine(aHashtable.ContainsValue("Yeasin"));// true
            Console.WriteLine(aHashtable.ContainsKey(101));       // true
            Console.WriteLine(aHashtable.ContainsKey(101014));    // false
            Console.WriteLine(aHashtable.ContainsKey("Yeasin"));  // false

            Console.WriteLine(aHashtable[111]);                   // WOrld
            foreach (DictionaryEntry VARIABLE in aHashtable)
            {
                Console.WriteLine("{0},{1}",VARIABLE.Key,VARIABLE.Value);
            }
        }
    }
}
