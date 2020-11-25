using System;

namespace SnakesAndLadders
{
    public class GreenSnake : IJumper
    {
        private bool hasEaten = false;
        public int Start { get; }

        public int End { get; }

        public GreenSnake(int head, int tail)
        {
            Start = head;
            End = tail;
        }

        public int Jump()
        {
            if (!hasEaten)
            {
                hasEaten = true;
                return End;
            }
            return Start;
        }
    }
}
