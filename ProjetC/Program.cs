﻿namespace DungeonCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.Init();
            game.Start();
        }
    }
}