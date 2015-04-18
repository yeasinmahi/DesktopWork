using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01
{
    class Program
    {
        static void Main(string[] args)
        {
            UpperLower ul=new UpperLower();
            EvenNumber en=new EvenNumber();
            DivisorOf3and5 divisor= new DivisorOf3and5();
            NaturalNumberDifferent naturalNumber= new NaturalNumberDifferent();
            //ul.UpperLowerLimit();
            //en.EvenNum();
            //divisor.Divisor();
            //naturalNumber.NaturalNumber();
            
            do
            {
                Console.WriteLine("\n\t\t\t***Problem Set 01***\n\n\t01. Upper and Lower\n\t02. Even Number\n\t03. divisor of 3 and 5\n\t04. Natural Number\n\t05. Exit");
                string chk = Console.ReadLine();
                int menu;
                if (int.TryParse(chk, out menu))
                {
                    switch (menu)
                    {
                        case 1:
                            ul.UpperLowerLimit();
                            break;
                        case 2:
                            en.EvenNum();
                            break;
                        case 3:
                            divisor.Divisor();
                            break;
                        case 4:
                            naturalNumber.NaturalNumber();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter Menue correctly");
                            break;
                    }
                    ;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Enter Integer value");
                    Console.ReadKey();
                } 
            } while (true);
        }
    }
}
