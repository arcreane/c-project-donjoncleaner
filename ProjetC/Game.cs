using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Game
    {
        public void DisplayInfos(Ennemi ennemi)
        {
            Console.WriteLine("\nName : Ennemi 1\nLife : {0}\nAtk : {1}\nDefence : {2}", ennemi.Health, ennemi.Attack, ennemi.Defence);
        }
    }
}