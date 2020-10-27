using System;

namespace SnakesAndLadders
{
    public class GreenSnake : IJumper
    {
        private bool hasEaten = false;
        public int Head { get; }

        public int Tail { get; }

        public GreenSnake(int head, int tail)
        {
            Head = head;
            Tail = tail;
        }

        public int Jump()
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
