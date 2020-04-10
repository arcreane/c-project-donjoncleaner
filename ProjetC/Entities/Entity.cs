using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    enum ENNEMI_TYPE{

    }
    class Entity
    {
       
        public Double Health { get; set; } = 100;
        public int Attack { get; set; } = 20;
        public int Defence { get; set; } = 10;

        public Entity()
        {

        }
    }
}
