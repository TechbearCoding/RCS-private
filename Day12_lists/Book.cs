using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Lists
{
    public class Book
    {
        public String name;
        public String authorName;
        public String authorLastName;
        public int year;

        public int PirmsCikGadiem()
        {
            return 2023 - this.year;
        }

        public Book(String name, String authorName, String authorLastName, int year)
        {
            this.name = name;
            this.authorName = authorLastName;
            this.authorLastName = authorLastName;
            this.year = year;
        }

        public void IzvaditInfo()
        {
            Console.WriteLine("gramatas nosaukums ir : " + name);
            Console.WriteLine("gramatas autora vards ir : " + authorName);
            Console.WriteLine("gramatas autora uzvafrds ir : " + authorLastName);
            Console.WriteLine("gramatas publikacijas gads ir : " + this.PirmsCikGadiem());
        }

    }
}
