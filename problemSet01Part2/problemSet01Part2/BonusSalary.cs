using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01Part2
{
    class BonusSalary
    {
        public void bonus()
        {
            double bonus=0;
            Console.Write("Enter the salary ");
            int salary=Convert.ToInt32(Console.ReadLine());
            if (salary > 10000)
            {
                bonus = salary*0.05;
            }
            else if (salary>=8000)
            {
                bonus = salary*.06;
            }
            else
            {
                bonus = salary*.07;
            }
            Console.WriteLine("Bonous Amount : "+bonus);
            Console.WriteLine("Total With Bonous : " + (bonus+salary));
            
        }
    }
}
