﻿using System;

namespace DungeonCleaner
{
    enum Enemy_Name
    {
        Chevalier,
        Barbare,
        Voleur,
        Mage,
        Archer,
    }
    class Entity
    {
        public String Name { get; set; }
        public int Health { get; set; } = 30;
        public int Attack { get; set; } = 20;
        public int Defence { get; set; } = 10;

        public Entity()
        {

        }
    }
}