using System.Collections.Generic;

namespace SnakesAndLadders
{
    public interface IGameStrategy
    {
        Player GetNextPlayer();
    }
}