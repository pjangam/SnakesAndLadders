using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadders
{
    public class Board
    {
        public Board(IEnumerable<ISnake> snakes)
        {
            Snakes = snakes;
        }

        public IEnumerable<ISnake> Snakes { get; }

        public int GetNextPosition(int diceThrow, int currentPlace)
        {
            var nextPlace = currentPlace + diceThrow;
            if (goingOutOfBoard(nextPlace)) nextPlace = currentPlace;

            var snake = GetSnake(nextPlace);
            if (snake != null) nextPlace = snake.Eat();

            return nextPlace;
        }

        private ISnake GetSnake(int place) => Snakes.FirstOrDefault(s => s.Head == place);
        private bool goingOutOfBoard(int nextPosition) => nextPosition > 100;
    }
}