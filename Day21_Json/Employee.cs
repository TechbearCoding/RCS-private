﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_Json { 

    public class Employee
    {
        public int id { get; set; }
        public String vards { get; set; }
        public String uzvards { get; set; }
        public String pilseta { get; set; }
        public String valsts { get; set; }

        public Employee(int id, String vards, String uzvards, String pilseta, String valsts)
        {
            this.id = id;
            this.vards = vards;
            this.uzvards = uzvards;
            this.pilseta = pilseta;
            this.valsts = valsts;
        }

        public void Print()
        {
            Console.WriteLine("id: " + id + ", vards: " + vards + ", uzvards: " + uzvards + ", pilseta: " + pilseta + ", valsts: " + valsts);
            Console.WriteLine("-----------------");
        }
    }
}
