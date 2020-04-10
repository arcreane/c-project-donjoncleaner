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
            Ennemi ennemi = new Ennemi();

            Console.WriteLine("Choisissez la difficulté générale du jeu :\n[1]-Easy\n[2]-MODERATE\n[3]-HARD\n[4]-DEATH");
            string Answer = Console.ReadLine();
            switch (Answer)
            {
                case "1":
                    ennemi.Level = Levels.EASY;
                    break;
                case "2":
                    ennemi.Level = Levels.MODERATE;
                    break;
                case "3":
                    ennemi.Level = Levels.HARD;
                    break;
                case "4":
                    ennemi.Level = Levels.DEATH;
                    break;
            }
        }
        /*public void Fight()
        {
            ICI LE FIGHT
        }*/
    }
}