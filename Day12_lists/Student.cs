using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Lists
{
    public class Student
    {
        public static String vards = "Arturs";
        public static String uzvards = "Abolins";
        private static List<int> atzimes = new List<int>();


        public static void PievienotAtzimesArr(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                atzimes.Add(arr[i]);
            }
        }

        public static void PievienotAtzimesList(List<int> list)
        {
            atzimes.AddRange(list);
        }
        public static void StudentaInfo()
        {
            Console.WriteLine("Studenta vards un uzvards ir : " + vards + uzvards);
            Console.WriteLine("Studenta videja atzime ir : " + VidejaAtzime(atzimes));
        }

        public static void PievienotAtzimi(int param)
        {
            atzimes.Add(param);
        }

        private static double VidejaAtzime(List<int> atzimes)
        {
            double result = 0;
            for (int i = 0; i < atzimes.Count; i++)
            {
                result += atzimes[i];

            }
            return result / atzimes.Count;
        }

        public static void IzdzestAtzimes()
        {
            atzimes.Clear();
        }
    }
}
