using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_objects
{
    public class PrivateSample
    {
        public static int a = 1;
        private static int b = 2;
        public static void Run()
        {
            int a = 3;
            b = 4;
           
            Console.WriteLine("Hello from PrivateSample");

            RunPublic(a);
            RunPublic(b);
            RunPublic(PrivateSample.a);
            RunPrivate();
        }

        private static void RunPrivate()
        {
            RunPublic(a);
            Console.WriteLine("Hello from PrivateSample");
        }

        public static void RunPublic(int param)
        {
            Console.WriteLine(param);
        }
    }
}
