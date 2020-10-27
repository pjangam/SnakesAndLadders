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
        private IGameStrategy _strategy = new SimpleGameStrategy();

        public Game Build() => new Game(_players, _dice, new Board(Snakes), _strategy); //send player to ctor

        public Player AddPlayer(Player player)
        {
            _players.Add(player);
            return player;
        }
        public ISnake AddSnake(ISnake snake)
        {
            Snakes.Add(snake);
            return snake;
        }
        public IDice SetDice(IDice dice)
        {

            _dice = dice;
            return dice;
        }
        public IGameStrategy SetStrategy(IGameStrategy strategy)
        {
            _strategy = strategy;
            return strategy;
        }
    }
}