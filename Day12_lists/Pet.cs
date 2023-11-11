using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Lists
{
    public class Pet
    {
        public String vards;
        public String tips;
        public int vecums;

        public Pet(String vards, String tips, int vecums)
        {
            this.vards = vards;
            this.tips = tips;
            this.vecums = vecums;
        }

        public void IzvaditInfo()
        {
            Console.WriteLine("Dzivnieka vards ir : " + vards);
            Console.WriteLine("Dzivnieka tips ir : " + tips);
            Console.WriteLine("Dzivnieka vecums ir : " + vecums);
        }
    }
}
