namespace Day8_oldtopics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskArrays();
        }

        static void TaskArrays()
        {
            Console.WriteLine("Ievadi masiva garumu!");
            int a = Convert.ToInt32(Console.ReadLine());

            double[] b = new double[a];

            Console.WriteLine("Ievadi visus masiva elementus!");

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToDouble(Console.ReadLine());
            }

            //uztaisit ciklu, kas iziet cauri masivam un izvada videjo vertibu

        }

        static void Sample1()
        {
            int[] a = new int[3];

            a[0] = 1;
            a[1] = 2;
            a[2] = 3;

            for(int i  = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
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