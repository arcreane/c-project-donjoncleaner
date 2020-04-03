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
        public static int Health { get; set; }
        public static int Attack { get; set; }
        public static int Defence { get; set; }
        public Entity(String name, int health, int attack, int defence)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defence = defence;
        }
    }
}
