using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_sqlite3
{
    public class Customer
    {
        public int id { get; set; }
        public String vards { get; set; }
        public String uzvards { get; set; }
        public String epasts { get; set; }

        public Customer(int id, String vards, String uzvards, String epasts)
        {
            this.id = id;
            this.vards = vards;
            this.uzvards = uzvards;
            this.epasts = epasts;
        }

        public Customer()
        {
            this.id = -1;
            this.vards = "";
            this.uzvards = "";
            this.epasts = "";
        }

        public void Print()
        {
            Console.WriteLine("id: " + id + ", vards: " + vards + ", uzvards: " + uzvards + ", pilseta: " + epasts);
            Console.WriteLine("-----------------");
        }
    }
        
}
