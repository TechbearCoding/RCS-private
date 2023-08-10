namespace Day4_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }

        private static void Task2()
        {
            String a = "";
            int b = 4;
            for (int i = 0; i < b; i++)
            {
                a = a + "#";
                Console.WriteLine(a);   
            }
        }

        private static void Task1()
        {
            
            int result = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ievadi " + i +  ". skaitli!");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                result = result + skaitlis;
            }
            Console.WriteLine(result);
        }

        private static void Sample3()
        {
            String a = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet savu vardu!");
                a = Console.ReadLine();
                Console.WriteLine(a);
            }
        }

        private static void Sample2()
        {
            int a = 5;
            //lai a vertiba mainitos deklaracijai ir jabut arpus cikla
            for (int i = 0; i < 5; i++)
            {
                a = a + 5;
                Console.WriteLine(a);
            }
        }

        static void Sample1()
        {
            //for, while, do..while
            for (int i = 0; i < 5; i++) //No kuras vertibas sakt, lidz kurai vertibai, i = i + 1
            //Cikls iet kamer i vertiba, kura sakuma ir 0 ir mazaka par pieci
            {
                Console.WriteLine(i);
                Console.WriteLine("Hello, World!");
            }
        }
    }
}