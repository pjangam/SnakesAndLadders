using System;

namespace SnakesAndLadder
{
    public class CrookedDice : IDice
    {
        private Random _random = new Random();
        public CrookedDice()
        {
        }

        public int Throw() => (_random.Next(3) + 1) * 2;
    }
}
