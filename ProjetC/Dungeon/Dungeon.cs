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
        public List<Room> Rooms { get; set; }
        public Dungeon()
        {
            
        }

        public void Enter(Hero hero, Levels level)
        {
            Hero = hero;

            Console.Clear();
            Console.WriteLine("Le héro vient de rentrer dans le donjon");

            // Faut faire un système (for) qui crée des rooms (jusqu'à 8) une par une et qui incrémente m_index et qui défini Room.Depth = m_index;
            for (m_index = 1; m_index <= 8; m_index++)
            {
                Room room = new Room(hero, level);
                room.Enter();
            }
        }
    }
}