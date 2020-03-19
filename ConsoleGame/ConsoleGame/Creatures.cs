using System;

namespace ConsoleGame
{
    internal abstract class Creatures : IDrawable
    {
        public ConsoleColor Color { get; set; } = ConsoleColor.Green;
        public string Symbol { get; } = "C ";
        public Cell Cell { get; }
        public Creatures(Cell cell, string symbol)
        {
            Cell = cell;
            Symbol = symbol;
        }

    }
}