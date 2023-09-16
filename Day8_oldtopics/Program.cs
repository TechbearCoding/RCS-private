namespace Day8_oldtopics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String vertiba = "asdssdg";

            String result = Nosaukums(vertiba);
            result = Nosaukums("asdbjjkb");

            double sk = 4.5;

            Console.WriteLine(Uzd2(2, 3));


            Console.WriteLine("Ievadi pirmo skaitli!");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadi otro skaitli!");
            double skaitlis2 = Convert.ToDouble(Console.ReadLine());

            double metode = Uzd2(skaitlis1, skaitlis2);
            Console.WriteLine(metode);
            Console.ReadLine();
        }

        static double Uzd2(int skaitlis1, double skaitlis2)
        {
            double result = 1;
            for (int i = 0; i < skaitlis1; i++)
            {
                result = result * skaitlis2;
            }
            return result;
        }

        static String Nosaukums(String a)
        {
            //Console.WriteLine("Hello world! " + a);

            return "Hello world! " + a;
        }

        static int Uzd1(int parametrs1)
        {
            int result = 0;
            for (int i = 0; i < parametrs1; i++)
            {
                Console.WriteLine("Ievadi skaitli!");
                int skaitlis2 = Convert.ToInt32(Console.ReadLine());
                result = result + skaitlis2;
            }
            return result;
        }
    }
}