using System;
using System.Collections.Generic;

namespace SnakesAndLadder
{

    public class Dice : IDice
    {
        private Random _random = new Random();

        public Dice()
        {
        }

        public int Throw() => _random.Next(6) + 1;
    }
}
