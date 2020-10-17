using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class GameBuilder
    {
        private IDice _dice = new Dice();
        private List<Player> _players = new List<Player>();
        private List<Snake> Snakes = new List<Snake>();

        public GameBuilder()
        {
        }

        public Player AddPlayer(Player player)
        {
            _players.Add(player);
            return player;
        }

        public Game Build() => new Game(_players, _dice, new Board(Snakes)); //send player to ctor

        public void AddSnake(Snake snake) => Snakes.Add(snake);

        public void SetDice(IDice dice) => _dice = dice;
    }

}