using System;
using System.Collections.Generic;
using System.Linq;

namespace GolfGame
{
    class Program
    {
        private static void Main(string[] args)
        {
            var game = new Golfer();
            Console.WriteLine("Here's our game");

            game.Play();
        }
    }
}
