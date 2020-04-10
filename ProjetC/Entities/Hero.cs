using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Hero
    {
        public string Name { get; set; }

        public string HeroName(String N)
        {
            Name = N;
            return N;
        }
    }
}
