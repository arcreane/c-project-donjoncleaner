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
                        Default_Health *= 1.2;
                        Default_Attack += 1;
                        Default_Defence += 1;
                        break;
                    case Levels.MODERATE:
                        Default_Health *= 1.5;
                        Default_Attack += 2;
                        Default_Defence += 2;
                        break;
                    case Levels.HARD:
                        Default_Health *= 1.75;
                        Default_Attack += 3;
                        Default_Defence += 3;
                        break;
                    case Levels.DEATH:
                        Default_Health *= 2.0;
                        Default_Attack += 4;
                        Default_Defence += 4;
                        break;
                    default:
                        break;
                }
            }
        }
        public Double Default_Health = 20.0;
        public int Default_Attack = 2;
        public int Default_Defence = 1;
        public Ennemi(String Name) : base(Name, Health, Attack, Defence)
        {
           
        }
    }
}
