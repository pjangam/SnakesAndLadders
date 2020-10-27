using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadders
{
    public class Board
    {
        public Board(IEnumerable<IJumper> snakes)
        {
            Snakes = snakes;
        }

        public IEnumerable<IJumper> Snakes { get; }

        public int GetNextPosition(int diceThrow, int currentPlace)
        {
            var nextPlace = currentPlace + diceThrow;
            if (goingOutOfBoard(nextPlace)) nextPlace = currentPlace;

            var jumper = GetJumper(nextPlace);
            if (jumper != null) nextPlace = jumper.Jump();

            return nextPlace;
        }

        private IJumper GetJumper(int place) => Snakes.FirstOrDefault(s => s.Start == place);
        private bool goingOutOfBoard(int nextPosition) => nextPosition > 100;
    }
}