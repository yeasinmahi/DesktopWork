using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgpa_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
 l:           Console.Write("Please Enter your number ");
            string number = Console.ReadLine();
            if (Int32.TryParse(number, out num))
            {
                string result = cgpaCalculate(num);
                Console.WriteLine(result);
                goto l;
            }
            else
            {
                Console.WriteLine("You did not input correct number");
                goto l;
            }
        }

        static string cgpaCalculate(int num)
        {
            if (num<=100 && num >=80)
            {
                return "You got A+";
            }
            else if (num < 80 && num >= 70)
            {
                return "You got A";
            }
            else if (num < 70 && num >= 60)
            {
                return "You got A-";
            }
            else if (num < 60 && num >= 50)
            {
                return "You got B";
            }
            else if (num < 50 && num >= 40)
            {
                return "You got C";
            }
            else if (num < 40 && num >= 33)
            {
                return "You got D";
            }
            else if (num < 33 && num >= 0)
            {
                return "Sorry!!! You have failed";
            }
            else
            {
                return "Please Enter your number in 1-100";
            }

        }
    }
}
