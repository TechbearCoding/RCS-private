using System.Numerics;
using System.Reflection.Metadata;

namespace Day9_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            //Sample1(a);

            int[] b = { 5, 2, 55, 99, 1 };
            //Sample1(b);

            //Console.WriteLine(Uzd2(b));
            Sample3();
 
        }

        static void Sample4(List<int> a) 
        {
            //...
        }

        static List<int> Sample5()
        {
            List<int> saraksts = new List<int>();

            //...

            return saraksts;
        }

        static void Sample3()
        {
            List<int> saraksts = new List<int>();
            saraksts.Add(1);
            saraksts.Add(22);
            saraksts.Add(89);

            for(int i = 0; i < saraksts.Count; i++)
            {
                Console.WriteLine(saraksts[i]);
            }

            List<String> stringuSaraksts = new List<String>();
            stringuSaraksts.Add("Kaut kads");
            stringuSaraksts.Add("Teksts");

            //izsaukt ar param
            Sample4(saraksts);

        }

        static int[] Uzd3()
        {
            int[] masivs = new int[6];
            Console.WriteLine("Ievadi 6 skaitlus!");
            for (int i = 0; i < 6; i++)
            {
                masivs[i] = Convert.ToInt32(Console.ReadLine());
            }

            return masivs;
        }

        static int Uzd2(int[] parametrs)
        {
            int result = parametrs[0];
            for (int i = 1; i < parametrs.Length; i++)
            {
                if (result < parametrs[i])
                {
                    result = parametrs[i];
                }
            }
            return result;
        }

        static int[] Sample2()
        {
            int[] a = { 1, 2, 3 };
            //masivu jebkada veidā, bet šis ir piemēram

            return a;
        }



        static void Uzd1(int[] parametrs)
        {
            for (int i = 0; i < parametrs.Length; i++)
            {
                if (parametrs[i] % 2 != 0)
                {
                    Console.Write(parametrs[i]);
                }
            }
        }

        static void Sample1(int[] parametrs)
        {
            //metode, kas izvada masivu
            for(int i = 0; i < parametrs.Length; i++)
            {
                Console.Write(parametrs[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static void MD()
        {
            int garums = Garums();
            String[] masivs = new String[garums];
            for (int i = 0; i < garums; i++)
            {
                String ievade = Console.ReadLine();
                if (ievade.Length < 5)
                {
                    masivs[i] = "aaa";
                }
                else
                {
                    masivs[i] = ievade;
                }
            }
        }
        static int Garums()
        {
            Console.WriteLine("Ievadi skaitli!");
            int masivaGarums = Convert.ToInt32(Console.ReadLine());
            return masivaGarums;
        }
    }
}