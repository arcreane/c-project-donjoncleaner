using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Game
    {
        public void DisplayInfos(Entity entity)
        {
            Console.WriteLine("\nName : {0}\nLife : {1}\nAtk : {2}\nDefence : {3}", entity.Name, entity.Health, entity.Attack, entity.Defence);
        }
    }
}