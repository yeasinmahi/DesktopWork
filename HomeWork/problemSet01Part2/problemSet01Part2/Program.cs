using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemSet01Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber primeNumber= new PrimeNumber();
            Greeting greeting= new Greeting();
            LongToInt longToInt= new LongToInt();
            AsciValue asciValue= new AsciValue();
            Circle circle = new Circle();
            BonusSalary bonusSalary= new BonusSalary();
            //primeNumber.primeNumber();
            //greeting.greeting();
            //longToInt.LongInt();
            //asciValue.asciValue();
            //circle.circle();
            //bonusSalary.bonus();

            do
            {
                Console.WriteLine("\n\t\t\t***Problem Set 1 Part-2***\n\n\t1. Check Prime Number\n\t2. Greeting\n\t3. Convert Long To Int\n\t4. ASCII Value of a charecter\n\t5. Area of a Cirle\n\t6. Bonus Counter\n\t7. Exit");
                string chk = Console.ReadLine();
                int menu;
                if (int.TryParse(chk, out menu))
                {
                    switch (menu)
                    {
                        case 1:
                            primeNumber.primeNumber();
                            break;
                        case 2:
                            greeting.greeting();
                            break;
                        case 3:
                            longToInt.LongInt();
                            break;
                        case 4:
                            asciValue.asciValue();
                            break;
                        case 5:
                            circle.circle();
                            break;
                        case 6:
                            bonusSalary.bonus();
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter Menu correctly");
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
