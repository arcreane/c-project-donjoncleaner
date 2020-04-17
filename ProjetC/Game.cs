using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Game
    {
        public Levels level;
        public Game() 
        {
            bool DifficultySelection = true;
            bool Selection = true;
            do
            {
                do
                {
                    Console.WriteLine("\nChoisissez la difficulté générale du jeu :\n[1]-Easy\n[2]-MODERATE\n[3]-HARD\n[4]-DEATH");
                    string Answer = Console.ReadLine();
                    level = (Levels)(int.Parse(Answer) - 1);
                    if ((int.Parse(Answer) - 1) > 3 || (int.Parse(Answer) - 1) < 0)
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

                Console.WriteLine("\nVotre mode de jeu a été réglé en : {0}", level);
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
        }

        public Levels GetLevel()
        {
            return level;
        }
        public void DisplayInfos(Entity entity)
        {
            Console.WriteLine("\nName : {0}\nLife : {1}\nAtk : {2}\nDefence : {3}", entity.Name, entity.Health, entity.Attack, entity.Defence);
        }
    }
}