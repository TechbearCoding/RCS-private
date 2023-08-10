namespace Day6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample3();
        }

        static void Sample3()
        {
            String input = "";

            do
            {
                Console.WriteLine("Ievadiet virkni!");
                input = Console.ReadLine();
                Console.WriteLine(input);
            } while (input != "exit");
        }

        static void Sample2()
        {
            String input = "";

            while(input != "exit")
            {
                Console.WriteLine("Ievadiet virkni!");
                input = Console.ReadLine();
                Console.WriteLine(input);
            }
        }

        static void Sample1()
        {
            int skaititajs = 0;

            while(skaititajs < 5)
            {
                skaititajs++;
                Console.WriteLine(skaititajs);
            }

        }
    }
}