using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC.Dungeon
{
    class Battle
    {
        public Hero Hero { get; set; }
        public Ennemi Ennemi { get; set; }

        private Boolean m_turn;

        public Battle(Hero hero, Ennemi ennemi)
        {
            Hero = hero;
            Ennemi = ennemi;


        }
    }
}
