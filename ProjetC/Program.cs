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

            Ennemi ennemi = new Ennemi("Ennemi A");

            Console.WriteLine("Choisissez la difficulté:\n[1]-Easy\n[2]-MODERATE\n[3]-HARD\n[4]-DEATH");
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
            Console.WriteLine("{0}\nHealth : {1}\nAttack : {2}\nDefence : {3}",Entity.Name, Entity.Health, Entity.Attack, Entity.Defence) ;
            Console.ReadLine();
        }
    }
}
