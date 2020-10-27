using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Board
    {
        public Board(IEnumerable<ISnake> snakes)
        {
            Snakes = snakes;
        }

        public IEnumerable<ISnake> Snakes { get; }
    }
}