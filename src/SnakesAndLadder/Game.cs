using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Game
    {
        public List<Player> Players { get; }
        private IDice _dice;

        public Game(List<Player> players, IDice dice)
        {
            Players = players;
            _dice = dice;
        }

        public int Play()
        {
            var diceThrow = _dice.Throw();
            if (Players[0].Place + diceThrow <= 100)
                Players[0].Place += diceThrow;
            return diceThrow;
        }
    }
}