using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCleaner
{
    class Dungeon
    {
        private int m_index = 1;

        public Hero Hero { get; set; }
        public Room Room { get; set; }
        public Dungeon()
        {
            
        }

        public void Enter(Hero hero)
        {
            Hero = hero;

            Console.Clear();
            Console.WriteLine("Le héro vient de rentrer dans le donjon");

            // Faut faire un système (for) qui crée des rooms (jusqu'à 8) une par une et qui incrémente m_index et qui défini Room.Depth = m_index;

            Console.ReadLine(); // à supprimer
        }
    }
}