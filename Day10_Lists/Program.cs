using System.Collections.Generic;

namespace Day10_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Samples.Sample1();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Tasks.Md2(a);

            List<int> b = Tasks.Uzd1(a);
            
        }

      

        /*Uztaisīt metodi, kas kā parametru paņem masīvu(padot no 1. uzdevuma masīvu) 
        un visus masīva elementus ieliek sarakstā(List) un izvadīt sarakstu ar metodi, 
        kuru izveidojām nodarbības beigās*/
    }
}