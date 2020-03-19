using System;
using System.Collections.Generic;

namespace ConsoleGame
{
    internal class Cell : IDrawable
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public string Symbol => ". ";

        public ConsoleColor Color { get; set; }
        public Cell()
        {
            Color = ConsoleColor.Red;
        }

    }
}