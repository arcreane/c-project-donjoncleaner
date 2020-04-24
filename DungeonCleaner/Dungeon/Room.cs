using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawler
{
    class Room
    {
        private List<Ennemi> ennemis = new List<Ennemi>();
        private int m_count;

        public Hero Hero { get; set; }
        public int Depth { get; set; }

        public Room(Hero hero, Levels level) 
        {
            Hero = hero;

            switch (level)
            {
                case Levels.EASY:
                    m_count = 2;
                    break;
                case Levels.MODERATE:
                    m_count = 3;
                    break;
                case Levels.HARD:
                    m_count = 4;
                    break;
                case Levels.DEATH:
                    m_count = 5;
                    break;
                default:
                    break;
            }

            for (int i = 0; i < m_count; i++)
            {
                ennemis.Add(new Ennemi());
            }
        }
    }
}
