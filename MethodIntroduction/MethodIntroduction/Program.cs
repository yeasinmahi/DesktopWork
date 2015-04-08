using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntroduction
{
    class Program
    {
        private const double pai = 3.1416;
        static void Main(string[] args)
        {
            Console.WriteLine(GetValue());
            /*int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Add="+add(firstNumber,secondNumber));
            Console.WriteLine("sub=" + sub(firstNumber, secondNumber));
            Console.WriteLine("Mul=" + mul(firstNumber, secondNumber));
            Console.WriteLine("Div=" + div(Convert.ToDouble(firstNumber), Convert.ToDouble(secondNumber)));

            string name=Console.ReadLine();
            GetName(name);*/

            double r = Convert.ToDouble(Console.ReadLine());
            Perimeter(r);
            Area(r);
        }

        static string GetValue()
        {
            return "Hello World";
        }

        static int add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
        static int sub(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }
        static int mul(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
        }
        static double div(double firstNumber, double secondNumber)
        {
            double result = Convert.ToDouble(firstNumber / secondNumber);
            return result;
        }

        static void GetName( string name)
        {
            Console.WriteLine("Hello, "+name);
        }

        static void Perimeter(double r)
        {
            Console.WriteLine(" Perimeter ="+2*pai*r);
        }
        static void Area(double r)
        {
            Console.WriteLine(" Area =" + pai * r*r);
        }

    }
}
