using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class Game
    {
        private IDice _dice;

        public Game(List<Player> players, IDice dice, Board board)
        {
            _dice = dice;
            Players = players;
            Board = board;
        }
        public List<Player> Players { get; }
        public Board Board { get; }

        public int Play()
        {
            var diceThrow = _dice.Throw();
            if (Players[0].Place + diceThrow <= 100)
                Players[0].Place += diceThrow;
            var snake = GetSnake(Players[0].Place);
            if (snake != null)
            {
                Players[0].Place = snake.Tail;
            }
            return diceThrow;
        }

        private Snake GetSnake(int place) => Board.Snakes.Find(s => s.Head == place);
    }
}