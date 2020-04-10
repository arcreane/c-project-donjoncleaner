using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    enum Levels
    {
        EASY,
        MODERATE,
        HARD,
        DEATH
    }
    class Ennemi : Entity
    {

        private Levels m_eLevel;
        public Levels Level
        {
            get
            {
                return m_eLevel;
            }

            set
            {
                m_eLevel = value;
                switch (m_eLevel)
                {
                    case Levels.EASY:
                        Ennemi.Health *= 1.2;
                        Ennemi.Attack += 15;
                        Ennemi.Defence += 10;
                        break;
                    case Levels.MODERATE:
                        Ennemi.Health *= 1.5;
                        Ennemi.Attack += 25;
                        Ennemi.Defence += 20;
                        break;
                    case Levels.HARD:
                        Ennemi.Health *= 1.75;
                        Ennemi.Attack += 35;
                        Ennemi.Defence += 35;
                        break;
                    case Levels.DEATH:
                        Ennemi.Health *= 2.0;
                        Ennemi.Attack += 45;
                        Ennemi.Defence += 40;
                        break;
                    default:
                        break;
                }
            }
        }
        public Ennemi() : base(Name, Health, Attack, Defence)
        {
            
        }
        
    }
}
