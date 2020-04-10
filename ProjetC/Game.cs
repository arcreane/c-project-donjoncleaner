using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Game
    {
        public void CharacterName()
        {

            bool valideName = false;

            do
            {
            Console.Write("Your journey is about to begin. What is your name ? : ");
            Hero hero = new Hero();
            hero.HeroName(Console.ReadLine());
            Console.Write("\nSo your name is " + hero.Name + " ? (yes/no) : ");
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
        } while (valideName == false);

        }

        public void GameDifficulty()
        {
            bool DifficultySelection = true;
            bool Selection = true;
            Ennemi ennemi = new Ennemi();
            do
            {
                do
                {
                    Console.WriteLine("\nChoisissez la difficulté générale du jeu :\n[1]-Easy\n[2]-MODERATE\n[3]-HARD\n[4]-DEATH");
                    string Answer = Console.ReadLine();
                    switch (Answer)
                    {
                        case "1":
                            ennemi.Level = Levels.EASY;
                            Selection = true;
                            break;
                        case "2":
                            ennemi.Level = Levels.MODERATE;
                            Selection = true;
                            break;
                        case "3":
                            ennemi.Level = Levels.HARD;
                            Selection = true;
                            break;
                        case "4":
                            ennemi.Level = Levels.DEATH;
                            Selection = true;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("La valeur {0} n'est pas valide !", Answer);
                            Selection = false;
                            break;
                    }
                } while (!Selection);

                Console.WriteLine("\nVotre mode de jeu a été réglé en : {0}", ennemi.Level);
                Console.WriteLine("Voulez-vous la modifier ? (yes/no)");
                string Validation = Console.ReadLine().ToLower();
                if(Validation == "yes")
                {
                    DifficultySelection = true;
                    Console.Clear();
                }
                else
                {
                    DifficultySelection = false;
                }
            } while (DifficultySelection);
        }
        public void Tuto()
        {
            Ennemi ennemi = new Ennemi();
            ennemi.SetName("Ennemi A");
            Console.WriteLine("{0} :\nHealth : {1}\nAttack : {2}\nDefence : {3}", ennemi.GetName(), ennemi.GetHealth(),ennemi.GetAttack(), ennemi.GetDefence());
            Console.ReadLine();
        }
    }
}