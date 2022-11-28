using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            GameOfLife gol = new GameOfLife(1000);
            gol.Run(100);
        }
    }
}
