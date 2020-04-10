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
        public  Double Health = 100;
        public  int Attack = 20;
        public  int Defence = 10;

        public string HeroName(String N)
        {
            Name = N;
            return N;
        }
    }
}
