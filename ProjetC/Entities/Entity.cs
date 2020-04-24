using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    enum Ennemi_Name
    {
        Chevalier,
        Barbare,
        Voleur,
        Mage,
        Archer,
    }
    class Entity
    {
        public String Name { get; set; }
        public Double Health { get; set; } = 100;
        public int Attack { get; set; } = 20;
        public int Defence { get; set; } = 10;

        public Entity()
        {

        }
    }
}