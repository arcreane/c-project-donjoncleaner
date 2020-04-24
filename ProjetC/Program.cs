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

            bool valideName = false;
            Hero hero = new Hero();

            do
            {

                Console.Write("Your journey is about to begin. What is your name ? : ");
                hero.Name = Console.ReadLine();
                Console.Write("\nSo your name is {0} ? (yes/no) : ", hero.Name);

                String Answer = Console.ReadLine();
                Answer = Answer.ToLower();

                if (Answer == "yes")
                {
                    valideName = true;
                }
                else if (Answer == "no")
                {
                    valideName = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please enter a valide anwser !\n");
                }
            }
            while (valideName == false);

            Ennemi ennemi = new Ennemi();
            Game game = new Game();
            ennemi.Level = game.GetLevel();
            /*game.DisplayInfos(ennemi);
            game.DisplayInfos(hero);*/

            Room room = new Room();

            room.SetEnnemis(3);


            Console.ReadLine();
        }
    }
}