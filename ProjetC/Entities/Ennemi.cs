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
                        setValues(1.2, 15, 10);
                        break;
                    case Levels.MODERATE:
                        setValues(1.5, 25, 20);
                        break;
                    case Levels.HARD:
                        setValues(1.75, 35, 30);
                        break;
                    case Levels.DEATH:
                        setValues(2, 45, 40);
                        break;
                    default:
                        break;
                }
            }
        }

        void setValues(double health, int atack, int defence)
        {
            Health *= health;
            Attack += atack;
            Defence += defence;
        }


        public Ennemi() : base()
        {

        }
    }
}
