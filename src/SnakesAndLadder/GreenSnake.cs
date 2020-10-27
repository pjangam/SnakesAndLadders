using System;
using SnakesAndLadders;

namespace SnakesAndLadder
{
    public class GreenSnake : ISnake
    {
        private bool hasEaten = false;
        public int Head { get; }

        public int Tail { get; }

        public GreenSnake(int head, int tail)
        {
            Head = head;
            Tail = tail;
        }

        public int Eat()
        {
            if (!hasEaten)
            {
                hasEaten = true;
                return Tail;
            }
            return Head;
        }
    }
}
