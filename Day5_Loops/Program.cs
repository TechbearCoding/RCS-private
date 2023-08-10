namespace Day5_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sample1(7);
            //Sample1(5);

            //Console.WriteLine(Sample2(2, 3));

            int a = Uzd3(-1);
            Console.WriteLine(a);
        }

        static void MD3()
        {
            int summa = 0;

            Console.WriteLine("Ievadi cik skaitlus cik gribi");
            int reizes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < reizes; i++)
            {
                Console.WriteLine("Ievadi skaitli");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                summa = summa + skaitlis;
            }
            Console.WriteLine(summa);
        }

        static void Sample1(int number)
        {
            Console.WriteLine(number);
        }

        static int Sample2(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }

        static int Uzd3(int skaitlis)
        {
            int result = 0;

            if (skaitlis <= 0)
            {
                Console.WriteLine("Kluda");
                return 0;
            }
            for (int i = 1; i <= skaitlis; i++)
            {
                result = result + i;
            }

            return result;

        }
    }
}