using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Game
    {
        public void Tuto(Hero hero)
        {
            Console.WriteLine("{0} :\nHealth : {1}\nAttack : {2}\nDefence : {3}", hero.Name, hero.Health, hero.Attack, hero.Defence);

            Ennemi ennemi = new Ennemi("Ennemi A",15,20,30);
            
            Console.WriteLine("\n{0} :\nHealth : {1}\nAttack : {2}\nDefence : {3}", ennemi.Name, ennemi.Health,ennemi.Attack, ennemi.Defence);
            Console.ReadLine();
        }
    }
}