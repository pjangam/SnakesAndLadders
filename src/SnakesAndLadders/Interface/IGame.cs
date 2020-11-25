using System.Collections.Generic;

namespace SnakesAndLadders
{
    public interface IGame
    {
        IEnumerable<Player> Players { get; }
        Board Board { get; }
        Player CurrentPlayer { get; }

        int Play();
    }
}