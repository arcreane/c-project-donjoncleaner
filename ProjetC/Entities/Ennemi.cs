using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Ennemi : Entity
    {
        public int Level { get; set; }
        public Double Default_Health = 20.0;
        public int Default_Attack = 2;
        public int Default_Defence = 1;
        public Ennemi(String name) : base(Name, Health, Attack, Defence)
        {
            switch (Level)
            {
                case 2:
                    Default_Health *= 1.2;
                    Default_Attack += 1;
                    Default_Defence += 1;
                    break;
                case 3:
                    Default_Health *= 1.5;
                    Default_Attack += 2;
                    Default_Defence += 2;
                    break;
                case 4:
                    Default_Health *= 1.75;
                    Default_Attack += 3;
                    Default_Defence += 3;
                    break;
                case 5:
                    Default_Health *= 2.0;
                    Default_Attack += 4;
                    Default_Defence += 4;
                    break;
                default:
                    break;
            }

            
            Health = Default_Health;
            Attack = Default_Attack;
            Defence = Default_Defence;
        }

        public String GetName()
        {
            return Name;
        }

        public Double GetHealth()
        {
            return Health;
        }
        public int GetAttack()
        {
            return Attack;
        }

        public int GetDefence()
        {
            return Defence;
        }

        // On essaie de donner un niveau à un ennemi et en fonction du niveau le switch donne des attributs différents 
        // Mais quand on WritleLine les paramètres sont nul
        public void SetLevel(int level)
        {
            Level = level;
        }
    }
}
