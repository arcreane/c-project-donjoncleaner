using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCleaner
{
    class Battle
    {
        public Hero Hero { get; set; }
        public Enemy Enemy { get; set; }

        private Boolean m_turn;

        public Battle(Hero hero, Enemy Enemy)
        {
            Hero = hero;
            Enemy = Enemy;

        }
    }
}
