using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class SimpleGameStrategy : IGameStrategy
    {

        public Player GetNextPlayer(CircularLinkedList<Player> _players)
        {
            _players.MoveNext();
            return _players.Current;
        }
    }
}