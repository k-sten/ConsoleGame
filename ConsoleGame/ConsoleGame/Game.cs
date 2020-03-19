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
                Console.ReadKey();
            } while (gameInProgress);
        }

        private void DrawMap()
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y,x);
                    //Console.ForegroundColor = cell?.Color ?? ConsoleColor.White;
                    //Console.Write(cell.Symbol);
                    IDrawable drawable = cell;

                    foreach (var creature in map.Creatures)
                    {
                        if (creature.Cell == cell)
                        {
                            drawable = creature;
                            break;
                        }
                    }

                    Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White;
                    Console.Write(drawable?.Symbol);
                }
                Console.WriteLine();
            }
        }

        private void Initialize()
        {
            //ToDo: Read from config later
            map = new Map(width: 10, height: 10);
            var heroCell = map.GetCell(0, 0);
            hero = new Hero(heroCell);
            map.Creatures.Add(hero);
        }
    }
}