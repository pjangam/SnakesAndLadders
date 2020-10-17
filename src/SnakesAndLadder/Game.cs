using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Game
    {
        public List<Player> Players { get; }
        private Dice _dice;

        public Game(List<Player> players, Dice dice)
        {
            Players = players;
            _dice = dice;
        }

        public int Play()
        {
            var diceThrow = _dice.Throw();
            Players[0].Place += diceThrow;
            return diceThrow;
        }
    }
}