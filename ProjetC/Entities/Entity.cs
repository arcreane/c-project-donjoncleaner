using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Entity
    {
        public static String Name { get; set; }
        public static Double Health = 20;
        public static int Attack = 2;
        public static int Defence = 1;
        public Entity(String name, double health, int attack, int defence)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defence = defence;
        }
    }
}
