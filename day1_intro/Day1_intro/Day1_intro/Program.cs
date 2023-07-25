using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!"); //Vienkārša izvade
            Console.WriteLine("1 + 2"); //= 1 + 2
            Console.WriteLine("1" + "2");//= 12
            Console.WriteLine(1 + "2"); //= 12
            Console.WriteLine(1 + 2); //= 3
            Console.WriteLine("abc " + "cda"); //= abccda
            // + - / * 

            Console.WriteLine("Ievadi savu vārdu!");
            String input = Console.ReadLine();
            Console.WriteLine(input);

            input = "abs"; //vertibu var mainit
            Console.WriteLine(input);

            int skaitlis;
            skaitlis = 4;
            Console.WriteLine(skaitlis); //pirms izsaukt so, obligati ir jabut vertibai
            int rezultats = 1 + 2;
            rezultats = 3 - 2;
            rezultats = skaitlis + 1;

            int b = Convert.ToInt32("12"); //konverte skaitli no string uz int
            Console.WriteLine(b);

            Console.WriteLine("Ievadi skaitli!");
            int a = Convert.ToInt32(Console.ReadLine()); //konverte cilveka ievadi
        }
    }
}