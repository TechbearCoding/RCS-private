using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample4();
        }

        static void Sample4()
        {
            double a = 5.5;
            int b = 4;
            a = Convert.ToDouble(Console.ReadLine());
            double result = a + b;
            Console.WriteLine(result);
        }

        private static void Sample3()
        {
            Console.WriteLine("Ievadi skaitli");
            int first = Convert.ToInt32(Console.ReadLine());

            //Izvadit ##, ja skaitlis ir pozitivs, izvadit #, ja skaitlis ir vai nu negativs vai 0
            if (first < 0 || first == 0)
            {
                Console.WriteLine("#");
            }
            else
            {
                Console.WriteLine("##");
            }
        }

        private static void Sample2()
        {
            Console.WriteLine("Ievadi skaitli");
            int first = Convert.ToInt32(Console.ReadLine());

            //izvadit kludas pazinojumu, ja skaitlis ir lielaks par 5 un ari, ja ir mazaks par 0
            if(first > 5 || first < 0)
            {
                Console.WriteLine("Kluda!");
            }
            else
            {
                Console.WriteLine(first);
            }

            if (first <= 5 && first >= 0)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine("Kluda!");
            }
        }

        static void Sample1()
        {
            //UZtaisit metodi, kas ar return atgriez lielako skaitli. Parametri- 2 int tipa skaitli
            int c = 4;
            int d = 5;

            int a = CompareTwoNumbers(c , d); ;
            Console.WriteLine(a);
        }

        static int CompareTwoNumbers(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            return b;
        }

        private static void Md()
        {
            Console.WriteLine("Ievadi pirmo skaitli");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi treso skaitli");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lielakais skaitlis ir " + Compare(first, second, third));
        }

        private static int Compare(int first, int second, int third)
        {
            int result = 0;
            if (first < second) 
            {
                result = first;
            }
            else
            {
                result = second;
            }

            if(result < third) 
            {
                result = third;
            }

            return result;
        }
    }
}