using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class SimpleGameStrategy : IGameStrategy
    {
        private int _currentPlayerIndex = 0;
        private IList<Player> _players;
        public SimpleGameStrategy(IList<Player> players)
        {
            _players = players;
        }

        public Player GetNextPlayer()
        {
            _currentPlayerIndex++;
            if (_currentPlayerIndex == _players.Count)
            {
                _currentPlayerIndex = 0;
            }
            return _players[_currentPlayerIndex];
        }
    }
}