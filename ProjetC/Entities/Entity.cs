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

        public Entity(String Name, Double Health, int Attack, int Defence)
        {

        }

        public String GetName()
        {
            return Name;
        }
        public void SetName(String name)
        {
            Name = name;
        }

        public Double GetHealth()
        {
            return Health;
        }
        public void SetHealth(int health)
        {
            Health = health;
        }

        public int GetAttack()
        {
            return Attack;
        }
        public void SetAttack(int attack)
        {
            Attack = attack;
        }

        public int GetDefence()
        {
            return Defence;
        }
        public void SetDefence(int defence)
        {
            Defence = defence;
        }

    }
}
