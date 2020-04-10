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
                        Entity.Health *= 1.2;
                        Entity.Attack += 15;
                        Entity.Defence += 10;
                        break;
                    case Levels.MODERATE:
                        Entity.Health *= 1.5;
                        Entity.Attack += 25;
                        Entity.Defence += 20;
                        break;
                    case Levels.HARD:
                        Entity.Health *= 1.75;
                        Entity.Attack += 35;
                        Entity.Defence += 35;
                        break;
                    case Levels.DEATH:
                        Entity.Health *= 2.0;
                        Entity.Attack += 45;
                        Entity.Defence += 40;
                        break;
                    default:
                        break;
                }
            }
        }
        public Ennemi() : base(Name, Health, Attack, Defence)
        {
            Entity entity = new Entity("Test", 50, 15, 10);
        }
    }
}
