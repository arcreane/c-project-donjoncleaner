using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    public abstract class Entity
    {
        private string name;
        private int health;
        private int attack;
        private int defence;
        public void EntityName(string E_name)
        {
            name = E_name;
        }
    }
}
