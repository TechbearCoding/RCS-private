using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
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

            bool a = false;
            a = !a;

            int b = 5;
            b = b + 6; //b vertiba ir 11
        }

    }
}