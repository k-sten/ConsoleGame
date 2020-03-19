using System;

namespace ConsoleGame
{
    internal class Game
    {
        private Map map;
        private Hero hero;

        internal void Run()
        {
            Initialize();
            Play();
        }

        private void Play()
        {
            bool gameInProgress = true;
            do
            {
                DrawMap();
                //drawmap
                //get command
                //execute
                //drawmap
                //enemy actions
                //drawmap

            } while (gameInProgress);
        }

        private void DrawMap()
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y,x);
                    Console.Write(cell.Symbol);
                }
                Console.WriteLine();
            }
        }

        private void Initialize()
        {
            //ToDo: Read from config later
            map = new Map(width: 10, height: 10);
            hero = new Hero();
        }
    }
}