using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Game
    {
        public void Tuto()
        {
            Entity entity = new Entity();
            Console.WriteLine("Name : Ennemi 1\nLife : {0}\n Atk : {1}\nDef : {2}", entity.Health, entity.Attack, entity.Defence);
        }
    }
}