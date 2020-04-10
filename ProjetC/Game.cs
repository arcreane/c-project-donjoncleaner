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
            Console.WriteLine("{0} :\nHealth : {1}\nAttack : {2}\nDefence : {3}", hero.GetName(), hero.GetHealth(), hero.GetAttack(), hero.GetDefence());

            Ennemi ennemi = new Ennemi();
            ennemi.SetName("Ennemi A");
            Console.WriteLine("\n{0} :\nHealth : {1}\nAttack : {2}\nDefence : {3}", ennemi.GetName(), ennemi.GetHealth(),ennemi.GetAttack(), ennemi.GetDefence());
            Console.ReadLine();
        }
    }
}