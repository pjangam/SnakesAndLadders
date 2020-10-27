using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadders
{
    public class GameBuilder
    {
        private IDice _dice = new Dice();
        private List<Player> _players = new List<Player>();
        private List<ISnake> Snakes = new List<ISnake>();

        public GameBuilder()
        {
        }

        public Player AddPlayer(Player player)
        {
            _players.Add(player);
            return player;
        }

        public Game Build() => new Game(_players, _dice, new Board(Snakes), new SimpleGameStrategy(_players.ToList())); //send player to ctor

        public void AddSnake(ISnake snake) => Snakes.Add(snake);

        public void SetDice(IDice dice) => _dice = dice;
    }

}