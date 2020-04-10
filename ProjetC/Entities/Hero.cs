using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC
{
    class Hero
    {
        public String Name { get; set; }

        public string SetHeroName(String name)
        {
            Name = name;
            return Name;
        }
    }
}
