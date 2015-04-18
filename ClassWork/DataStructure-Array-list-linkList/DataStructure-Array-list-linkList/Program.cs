using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Array_list_linkList
{
    class Program
    {
        static void Main(string[] args)
        {
            //************ Array*****************
            //int[] number = new int[5];
            //number[0] = 1;
            //number[1] = 85;
            //number[2] = 17;
            //number[3] = 118;
            //number[4] = 65;

            //Array.Sort(number);
            ////Array.Reverse(number);
            //Console.WriteLine(Array.FindLast(number, i => i>50));
            //Console.WriteLine("Lenght: "+ number.Length);
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}
            //Console.WriteLine();

            //foreach (int num in number)
            //{
            //    Console.WriteLine(num);
            //}

            //string[] helloWorld = new[] {"Hello", "World"};

            //************ ArrayList*****************
            //ArrayList myArrayList= new ArrayList();

            //myArrayList.Add(1);
            //myArrayList.Add("Yeasin");
            //myArrayList.Add(3.07);

            //myArrayList.Add(2);
            //myArrayList.Add("Monir");
            //myArrayList.Add(3.50);

            //myArrayList.Add(3);
            //myArrayList.Add("masud");
            //myArrayList.Add(3.97);

            //int rang=0;
            //foreach (var arrayList in myArrayList)
            //{
            //    Console.WriteLine(arrayList);
                
            //}

            //int rang = 0;
            //for(int i=0;i<myArrayList.Count;i++)
            //{
            //    Console.WriteLine(myArrayList[rang++]);
            //    Console.WriteLine(myArrayList[rang++]);
            //    Console.WriteLine(myArrayList[rang++]);
            //    i += 3;


            //}

            //************ List*****************

            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine();
            List<string> myList2 = new List<string>();

            myList2.Add("a");
            myList2.Add("b");
            myList2.Add("c");
            myList2.Add("d");
            myList2.Add("e");
            myList2.Add("f");
            myList2.Add("g");
            foreach (string i in myList2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
