namespace Day6_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sk = Sample7();
        }

        private static int Sample7()
        {
            Boolean exit = false;
            int skaitlis = 0;
            while (exit == false)
            {    
                try
                {
                    Console.WriteLine("Ievadiet skaitli!");
                    skaitlis = Convert.ToInt32(Console.ReadLine());
                    exit = true;
                }
                catch
                {
                    Console.WriteLine("Kluda, megini vel!");
                }
            }
            return skaitlis;
        }

        private static void Sample6()
        {
            int skaitlis = 0;
            try
            {
                Console.WriteLine("Ievadiet skaitli!");
                skaitlis = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Kluda!");
            }

            Console.WriteLine(skaitlis);
        }

        private static void Sample5()
        {
            int a = 99;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int skaitlis = Convert.ToInt32(Console.ReadLine());

                if (skaitlis == a)
                {
                    Console.WriteLine("Uzmineji!");
                    break;
                }

                Console.WriteLine("Neuzmineji!");
            }
        }

        private static void Sample4()
        {
            while (true)
            {
                Console.WriteLine("Ievadiet virkni!");
                String input = Console.ReadLine();
                Console.WriteLine(input);

                if(input == "exit")
                {
                    break;
                }
            }

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