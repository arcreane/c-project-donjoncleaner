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
        public static Double Health = 100;
        public static int Attack = 20;
        public static int Defence = 10;
        public Entity(String name, double health, int attack, int defence)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defence = defence;
        }

    }
}
