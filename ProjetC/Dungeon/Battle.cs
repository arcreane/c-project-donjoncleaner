using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCleaner
{
    class Battle
    {
        public Hero Hero { get; set; }
        public Enemy Enemy { get; set; }

        private Boolean m_turn;

        public Battle(Hero hero, Enemy enemy)
        {
            Hero = hero;
            Enemy = enemy;
            bool canContinue = true;

            int HeroHealth = hero.Health;
            int HeroAttack = hero.Attack;
            int HeroDefence = hero.Defence;

            int EnemyHealth = enemy.Health;
            int EnemyAttack = enemy.Attack;
            int EnemyDefence = enemy.Defence;

            int damage;


            //Jouer avec les stats
            do
            {
                do
                {
                    //Si m_turn est égal à true, le hero commence

                    Console.WriteLine("Un ennmi se présente devant vous ! Vous vous mettez en posture de combat !");
                    if (m_turn)
                    {
                        Console.WriteLine("Quelle action souhaitez-vous exécuter ? \nt-[1]Attaquer ?\nt-[2]Defendre ?");
                        string userAnswer = Console.ReadLine();
                        bool isParsable;
                        int ParsedUserAnswer;
                        isParsable = int.TryParse(userAnswer, out ParsedUserAnswer);

                        //Ici faire un switch d'action :
                            //[1]Attaque
                            //[2]Defendre
                        //A la fin du tour, m_turn change de valeur
                        switch (ParsedUserAnswer)
                        {
                            case 1:
                                if (HeroAttack > EnemyDefence)
                                {
                                    //Si on attaque, on soustrait l'attaque à la défense adverse pour donner les dégâts net
                                    damage = (HeroAttack - EnemyDefence);
                                    EnemyHealth -= damage;
                                    m_turn = false;
                                }
                                else
                                {
                                    //Si la défense adverse est supérieur à notre l'attaque, on inflige 1 de dégat 
                                    EnemyHealth -= 1;
                                    m_turn = false;
                                }
                                canContinue = true;
                                break;
                            case 2:
                                //Si on défend, on la défense augmente de 5 points. 
                                //Si l'attaque est supérieur à la défense, on prend 1 de dégat 
                                canContinue = true;
                                break;
                            default:
                                Console.WriteLine("Veuillez entrer une réponse valide !");
                                canContinue = false;
                                break;
                        }

                    }
                } while (canContinue);

                //Si m_turn est égal à false, l'ennemi attaque
                //L'ennemi ne fait qu'attaquer

                //Lors de l'affrontement, L'attaque est soustraite à la défence pour infliger les dégâts net.
                //Si la défence du hero est suppérieur à l'attaque du monstre, il infligue 1 de dégat.

                //A la fin du tour, m_turn change de valeur

            } while (HeroHealth >0 && EnemyHealth >0);//Tant que la vie des joueur sont suppérieur à 0, le combat continue
        }
    }
}
