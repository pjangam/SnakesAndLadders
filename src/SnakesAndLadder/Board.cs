using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Board
    {
        public Board(List<Snake> snakes)
        {
            Snakes = snakes;
        }

        public List<Snake> Snakes { get; }
    }
}