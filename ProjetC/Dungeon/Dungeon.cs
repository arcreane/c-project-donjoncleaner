using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Dungeon
    {
        public Room Room { get; set; }
        public Dungeon()
        {

        }

        public void SetParameters(Room room)
        {
            Room = room;
        }
    }
}
