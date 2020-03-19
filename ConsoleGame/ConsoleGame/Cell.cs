using System.Collections.Generic;

namespace ConsoleGame
{
    internal class Cell
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public string Symbol => ". ";

        public Cell()
        {

        }

    }
}