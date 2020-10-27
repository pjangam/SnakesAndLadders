using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadders
{
    public class Game
    {
        private IDice _dice;

        public Game(IList<Player> players, IDice dice, Board board)
        {
            _dice = dice;
            Players = players;
            Board = board;

            CurrentPlayer = players[0];
        }
        public IEnumerable<Player> Players { get; }
        public Board Board { get; }
        public Player CurrentPlayer { get; }

        public int Play()
        {
            var diceThrow = _dice.Throw();
            if (CurrentPlayer.Place + diceThrow > 100)
                return diceThrow;

            CurrentPlayer.Place += diceThrow;

            var snake = GetSnake(CurrentPlayer.Place);
            if (snake != null)
            {
                CurrentPlayer.Place = snake.Eat();
            }
            return diceThrow;
        }

        private ISnake GetSnake(int place) => Board.Snakes.FirstOrDefault(s => s.Head == place);
    }
}