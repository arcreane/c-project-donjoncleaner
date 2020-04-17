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
                string name = Console.ReadLine();
                Console.Write("\nSo your name is {0} ? (yes/no) : ", name);

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
                    Console.WriteLine();
                }
            }
            while (valideName == false);

            bool DifficultySelection = true;
            bool Selection = true;
            Ennemi ennemi = new Ennemi();
            do
            {
                do
                {
                    Console.WriteLine("\nChoisissez la difficulté générale du jeu :\n[1]-Easy\n[2]-MODERATE\n[3]-HARD\n[4]-DEATH"); 
                    string Answer = Console.ReadLine();
                    ennemi.Level = (Levels)(int.Parse(Answer) - 1);
                    if((int.Parse(Answer) - 1) > 3 || (int.Parse(Answer) - 1) < 0)
                    {
                        Console.WriteLine("La reponse : {0} n'est pas valide !", (int.Parse(Answer)));
                        Selection = false;
                    }
                    else
                    {
                        Selection = true;
                    }
                }
                while (!Selection);

                Console.WriteLine("\nVotre mode de jeu a été réglé en : {0}", ennemi.Level);
                Console.WriteLine("Voulez-vous la modifier ? (yes/no)");
                string Validation = Console.ReadLine().ToLower();
                if (Validation == "yes")
                {
                    DifficultySelection = true;
                    Console.Clear();
                }
                else
                {
                    DifficultySelection = false;
                }
            }
            while (DifficultySelection);

            Game game = new Game();
            //Afficher ici les stats du 1er ennemi et du heros !
            game.Tuto();

            Console.ReadLine();
        }
    }
}
