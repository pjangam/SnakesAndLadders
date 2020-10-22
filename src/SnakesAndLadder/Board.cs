using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Board
    {
        public Board(IEnumerable<Snake> snakes)
        {
            Snakes = snakes;
        }

        public IEnumerable<Snake> Snakes { get; }
    }
}