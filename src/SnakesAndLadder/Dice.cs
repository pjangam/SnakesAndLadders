using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Dice
    {
        private Random _random = new Random();

        public Dice()
        {
        }

        public int Throw()
        {
            return _random.Next(6) + 1;
        }
    }
}
