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

            game.CharacterName();

            game.GameDifficulty();

            Ennemi ennemi = new Ennemi();
            Hero hero = new Hero();

            Console.WriteLine("{0} :\n");

            Console.WriteLine("Ennemi :\n{0}\nHealth : {1}\nAttack : {2}\nDefence : {3}",Entity.Name, Entity.Health, Entity.Attack, Entity.Defence) ;
            Console.ReadLine();
        }
    }
}
