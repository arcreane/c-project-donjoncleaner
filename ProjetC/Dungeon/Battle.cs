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

            //Jouer avec les stats
            do
            {
                //Si m_turn est égal à true, le hero commence

                //Ici faire un switch d'action :
                //[1]Attaque
                //[2]Defendre

                //Si on attaque, on soustrait l'attaque à la défense adverse pour donner les dégâts net.
                //Si la défense adverse est supérieur à notre l'attaque, on inflige 1 de dégat 
                //Si on défend, on la défense augmente de 5 points. 
                //Si l'attaque est supérieur à la défense, on prend 1 de dégat 

                //A la fin du tour, m_turn change de valeur



                //Si m_turn est égal à false, l'ennemi attaque
                //L'ennemi ne fait qu'attaquer

                //Lors de l'affrontement, L'attaque est soustraite à la défence pour infliger les dégâts net.
                //Si la défence du hero est suppérieur à l'attaque du monstre, il infligue 1 de dégat.

                //A la fin du tour, m_turn change de valeur

            } while ();//Tant que l'un des joueur ont une vie suppérieur à 0, le combat continue
        }
    }
}
