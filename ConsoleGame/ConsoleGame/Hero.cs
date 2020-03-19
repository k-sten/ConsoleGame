using System;

namespace ConsoleGame
{
    internal class Hero : Creatures
    {
        public Hero(Cell cell) : base(cell, "H ")
        {
            Color = ConsoleColor.Yellow;
        }
    }
}