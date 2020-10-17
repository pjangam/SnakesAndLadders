using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class GameBuilder
    {
        private List<Player> _players = new List<Player>();
        private Dice _dice = new Dice();
        public GameBuilder()
        {
        }

        public Player AddPlayer()
        {
            var player = new Player();
            _players.Add(player);
            return player;
        }

        public Game Build()
        {
            return new Game(_players, _dice); //send player to ctor
        }
    }
}