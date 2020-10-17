using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Game
    {
        private List<Player> _players;
        private Dice _dice;

        public Game(List<Player> players, Dice dice)
        {
            _players = players;
            _dice = dice;
        }
    }
}