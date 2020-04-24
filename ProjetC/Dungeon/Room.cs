using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Room
    {
        public void SetEnnemis(int inputNumber)
        {
            //On essaie de crée un nombre d'ennemi égal au nombre envoyé en paramètre puis de les concerver dans une liste

            int i;

            //Création de la liste 
            List<Ennemi> ennemiList = new List<Ennemi>();

            //Boucle afin de crée le bon nombre d'ennemi
            for (i = 0; i < inputNumber; i++)
            {
                //Création d'un ennemi
                Ennemi ennemi = new Ennemi();

                //Ajout à la liste
                ennemiList.Add(new Ennemi() {Name = ennemi.Name, Health = ennemi.Health, Attack = ennemi.Attack, Defence = ennemi.Defence });

                //Affichage de la liste
                Console.WriteLine(ennemiList[i]);
            }
        }
    }
}
