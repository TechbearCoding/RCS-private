using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_objects
{
    public class Students
    {
        public static String vards = "Arturs";
        public static String uzvards = "Abolins";

        private static List<int> atzimes = new List<int>();

        public static void PievienotAtzimi(int param)
        {
            atzimes.Add(param);
        }

        public static void StudentaInfo()
        {

            Console.WriteLine("Studenta vards un uzvards ir : " + vards + uzvards);
            Console.WriteLine("Studenta videja atzime ir : " + VidejaAtzime(atzimes));

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

    }
}
