using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictinaryIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> aDictionary= new Dictionary<int, string>();

            aDictionary.Add(101, "Md. ");
            aDictionary.Add(102, "Yeasin ");
            aDictionary.Add(103, "Arafat ");

            foreach (KeyValuePair<int, string> pair in aDictionary)
            {
                Console.Write(pair.Value);
            }
        }
    }
}
