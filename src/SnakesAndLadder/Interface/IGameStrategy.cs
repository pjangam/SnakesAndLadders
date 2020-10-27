using System.Collections.Generic;

namespace SnakesAndLadder
{
    public interface IGameStrategy
    {
        Player GetNextPlayer(CircularLinkedList<Player> _players);
    }
}