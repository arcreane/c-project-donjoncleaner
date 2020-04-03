using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Entity
    {
        public  String Name { get; set; }
        public static Double Health { get; set; }
        public static int Attack { get; set; }
        public static int Defence { get; set; }
        public Entity(String name, double health, int attack, int defence)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defence = defence;
        }
    }
}
