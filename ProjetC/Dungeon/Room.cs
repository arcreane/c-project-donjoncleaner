﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCleaner
{
    class Room
    {
        private int m_count;

        private List<Enemy> Enemies { get; set; }
        public Hero Hero { get; set; }
        public int Depth { get; set; }

        public Room(Hero hero, Levels level) 
        {
            Hero = hero;

            switch (level)
            {
                case Levels.EASY:
                    m_count = 2;
                    break;
                case Levels.MODERATE:
                    m_count = 3;
                    break;
                case Levels.HARD:
                    m_count = 4;
                    break;
                case Levels.DEATH:
                    m_count = 5;
                    break;
                default:
                    break;
            }

            Enemies = new List<Enemy>();
            for (int i = 0; i < m_count; i++)
            {
                Enemies.Add(new Enemy());
            }
        }

        public void Enter()
        {
            // foreach Enemies -> pour chaque Enemye Battle battle = new Battle(hero, enemy);
            foreach(Enemy enemy in Enemies)
            {
                Console.WriteLine("Salut");
                Battle battle = new Battle(Hero, enemy);
            }
        }

        public void Exit()
        {
            // Console.WriteLine ->
        }
    }
}
