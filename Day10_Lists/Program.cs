using System.Collections.Generic;

namespace Day10_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample1();
        }

        static void Sample1()
        {
            int[] a = { 1, 2, 3, 4, 5 };

            for(int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void IzvaditList(List<int> parametrs)
        {
            //metode, kas izvada masivu
            for (int i = 0; i < parametrs.Count; i++)
            {
                Console.Write(parametrs[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static void Md2(int[] masivs)
        {
            List<int> list = new List<int>();

            for(int i = 0; i < masivs.Length; i++)
            {
                list.Add(masivs[i]);
            }

            IzvaditList(list);
        }

        /*Uztaisīt metodi, kas kā parametru paņem masīvu(padot no 1. uzdevuma masīvu) 
        un visus masīva elementus ieliek sarakstā(List) un izvadīt sarakstu ar metodi, 
        kuru izveidojām nodarbības beigās*/
    }
}