using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Lists
{
    public class Tools
    {
        public static void IzvaditListu(List<int> lists)
        {
            for (int i = 0; i < lists.Count; i++)
            {
                Console.Write(lists[i]);
            }
            Console.WriteLine();
        }

        public static void IzvaditListu(List<String> lists)
        {
            for (int i = 0; i < lists.Count; i++)
            {
                Console.Write(lists[i]);
            }
            Console.WriteLine();
        }

        public static void IzvaditMasivu(int[] masivs)
        {
            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write(masivs[i]);
            }
            Console.WriteLine();
        }

        public static void IzvaditMasivu(String[] masivs)
        {
            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write(masivs[i]);
            }
            Console.WriteLine();
        }
    }
}
