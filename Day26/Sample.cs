using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day26
{
    public class Sample
    {
        public static int GetSum(int a, int b)
        {
            return a + b;
        }

        public static String Combine(String a, String b, String c)
        {
            if(a == "" || b == "" || c =="")
            {
                return "error";
            }
            return String.Concat(a, b, c);
        }
        
    }
}
