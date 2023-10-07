using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Lists
{
    public class Tasks
    {
        public Tasks() { }

        public static List<int> Uzd1(int[] masivs)
        {
            List<int> list = new List<int>();

            for (int i = masivs.Length - 1; i >= 0; i--)
            {
                list.Add(masivs[i]);
            }
            return list;
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

        public static void Md2(int[] masivs)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < masivs.Length; i++)
            {
                list.Add(masivs[i]);
            }

            IzvaditList(list);
        }
    }
}
