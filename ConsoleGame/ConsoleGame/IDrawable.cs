using System;

namespace ConsoleGame
{
    internal interface IDrawable
    {
        ConsoleColor Color { get; set; }
        string Symbol { get; }
    }
}