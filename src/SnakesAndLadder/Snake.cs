using System;

namespace SnakesAndLadders
{
    public class Snake
    {
        public int Head { get; }
        public int Tail { get; }

        public Snake(int head, int tail)
        {
            if (head >= 100) throw new ArgumentOutOfRangeException(nameof(head), head, "Snake head should be less than 100");
            if (tail <= 1) throw new ArgumentOutOfRangeException(nameof(tail), tail, "Snake tail should be greater than 1");
            if (head <= tail) throw new ArgumentException("Snake tail has to be below head");
            this.Head = head;
            this.Tail = tail;
        }
    }
}