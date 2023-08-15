namespace Day7_LoopsArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArraySample();
        }

        private static void ArraySample()
        {
            int[] nosaukums = new int[5];
            //0tais, 1ais, 2ais, 3ais, 4ais
            nosaukums[0] = 4;
            nosaukums[1] = 5;
            nosaukums[2] = 6;
            nosaukums[3] = 7;
            nosaukums[4] = 8;

            Console.WriteLine(nosaukums[0]);
            Console.WriteLine(nosaukums[1]);
            Console.WriteLine(nosaukums[2]);
            Console.WriteLine(nosaukums[3]);
            Console.WriteLine(nosaukums[4]);

            //---------------------

            int[] nosaukums2 = {4, 5, 6, 7, 8 };
            Console.WriteLine(nosaukums2[0]);
            Console.WriteLine(nosaukums2[1]);
            Console.WriteLine(nosaukums2[2]);
            Console.WriteLine(nosaukums2[3]);
            Console.WriteLine(nosaukums2[4]);

            //--------------------

            int[] nosaukums3 = new int[5];

            for(int i = 0; i < nosaukums.Length; i++)
            {
                Console.WriteLine("Ievadi vertibu!");
                nosaukums[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Md3()
        {
            Console.WriteLine("Ievadi cik ciparus gribi!");
            int times = Convert.ToInt32(Console.ReadLine());
            int ParaSkaitlis = 0;
            int NeparaSkaitlis = 0;
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Ievadi skaitli!");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    ParaSkaitlis = ParaSkaitlis + number;
                }
                if (number % 2 != 0)
                {
                    NeparaSkaitlis = NeparaSkaitlis + number; ;
                }
            }
            Console.WriteLine("Ir " + ParaSkaitlis + " para skaitli");
            Console.WriteLine("Ir " + NeparaSkaitlis + " nepara skaitli");

        }
        static void Md4()
        {
            Console.WriteLine("Ievadi 10 ciparus!");
            int skaitlusumma = 0;
            for (int i = 0; i < 10; i++)
            {
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                skaitlusumma = skaitlusumma + skaitlis;

                if (skaitlis % 2 != 0)
                {
                    Console.WriteLine("Ievadits nepara skaitlis");
                    break;
                }
            }
            Console.WriteLine("Skaitlu summa ir " + skaitlusumma);
        }
    }
}