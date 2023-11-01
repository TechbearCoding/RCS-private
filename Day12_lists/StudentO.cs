using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Lists
{
    public class StudentO
    {
        public String vards;
        public String uzvards;
        private List<int> atzimes = new List<int>();

        public StudentO(String vards, String uzvards)
        {
            this.vards = vards;
            this.uzvards = uzvards;
        }

        public StudentO()
        {
            vards = "";
            uzvards = "";
        }

        public void StudentaInfo()
        {
            Console.WriteLine("Studenta vards un uzvards ir : " + vards + uzvards);
            Console.WriteLine("Studenta videja atzime ir : " + VidejaAtzime());
        }

        public void PievienotAtzimesArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                atzimes.Add(arr[i]);
            }
        }

        public void PievienotAtzimesList(List<int> list)
        {
            atzimes.AddRange(list);
        }

        private double VidejaAtzime()
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
