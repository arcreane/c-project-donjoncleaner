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
                Hero hero = new Hero(Console.ReadLine());
                Console.Write("\nSo your name is " + hero  + " ? (yes/no) : ");
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
                    Console.Clear();
                }
            } while (valideName == false);
            
        }
    }
}