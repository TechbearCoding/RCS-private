using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Lists
{
    public class Samples
    {
        public Samples() 
        { 

        }

        public static void Sample1()
        {
            int[] a = { 1, 2, 3, 4, 5 };

            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
