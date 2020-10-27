using System.Collections.Generic;

namespace SnakesAndLadder
{
    public class SimpleGameStrategy : IGameStrategy
    {
        public SimpleGameStrategy()
        {
        }

        public Player GetNextPlayer(CircularLinkedList<Player> _players)
        {
            _players.MoveNext();
            return _players.Current;
        }
    }
}