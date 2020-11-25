using System;

namespace SnakesAndLadders
{
    public class Ladder : IJumper
    {
        public Ladder(int start, int end)
        {
            if (start <= 0) throw new ArgumentOutOfRangeException(nameof(start), start, "Ladder start should be more than 0");
            if (end >= 100) throw new ArgumentOutOfRangeException(nameof(end), end, "Ladder end should be less than 100");
            if (start >= end) throw new ArgumentException("Ladder end has to be above start");
            Start = start;
            End = end;
        }

        public int Start { get; }

        public int End { get; }

        public int Jump() => End;
    }
}
