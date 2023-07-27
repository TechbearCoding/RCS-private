using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(SaskaitisanaArReturn());

            int a = SaskaitisanaArReturn();
            Console.WriteLine(a);*/

            int a = 5;
            int b = 6;
            Console.WriteLine(ArReturnUnParam(a, b));
            Console.WriteLine(a + ", " + b);
            //Console.WriteLine(ArReturnUnParam(1,2));
            //Console.WriteLine(ArReturnUnParam(12, 78));

        }

        static void IfPiemers1()
        {
            //parbaudit vai skaitlis ir lielaks par 0 un izvadit pazinojumu
            Console.WriteLine("Ievadi skaitli!");
            int skaitlis = Convert.ToInt32(Console.ReadLine());
            // > < => <= != ==
            if (skaitlis > 0)
            {
                Console.WriteLine("Ir lielaks");
            }
            else if (skaitlis == 0)
            {
                Console.WriteLine("Skaitlis ir 0");
            }
            else
            {
                Console.WriteLine("Nav lielaks");
            }
        }

        static void IfPiemers2()
        {
            bool a = false;
            a = !a;

            int b = 5;
            b = b + 6; //b vertiba ir 11

            String simboli = "abc";
            if (simboli == "aaa")
            {
                Console.Write("Simbolu virknes ir vienadas");
            }

            IfPiemers1();
        }

        static int SaskaitisanaArReturn()
        {
            int a = 1;
            int b = 2;

            int result = a + b;
            
            return result;
        }


        static int ArReturnUnParam(int a, int b)
        {
            int result = a + b;

            a = 55;
            b = 7;

            Console.WriteLine(a + ", " + b);

            return result;
        }
    }
}