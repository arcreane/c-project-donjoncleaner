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

            game.Tuto();

            Console.ReadLine();
        }
    }
}
