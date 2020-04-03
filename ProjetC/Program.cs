using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# project !\n");

            Game game = new Game();

            /*game.CharacterName();

            Console.WriteLine("\nCongratulation ! You passed the Name test !");
            Console.ReadLine();*/
            Entity.Attack = 100;
            Entity.Defence = 150;
            Entity.Health = 20;
            Ennemi ennemi = new Ennemi("DFGHJKLM%");
            ennemi.Level = Levels.HARD;
            Console.WriteLine("Health : {0}\nAttack : {1}\nDefence : {2}", Entity.Health, Entity.Attack, Entity.Defence) ;
            Console.ReadLine();
        }
    }
}
