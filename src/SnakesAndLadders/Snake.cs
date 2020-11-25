using System;

namespace SnakesAndLadders
{

    public class Snake : IJumper
    {
        public int Start { get; }
        public int End { get; }
        public int Head { get => Start; }
        public int Tail { get => End; }

        public Snake(int head, int tail)
        {
            if (head >= 100) throw new ArgumentOutOfRangeException(nameof(head), head, "Snake head should be less than 100");
            if (tail <= 1) throw new ArgumentOutOfRangeException(nameof(tail), tail, "Snake tail should be greater than 1");
            if (head <= tail) throw new ArgumentException("Snake tail has to be below head");
            this.Start = head;
            this.End = tail;
        }

        public int Jump() => End;
    }
}