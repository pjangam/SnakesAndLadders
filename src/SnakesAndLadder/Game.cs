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

            CurrentPlayer = players[0];
        }
        public List<Player> Players { get; }
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
                CurrentPlayer.Place = snake.Tail;
            }
            return diceThrow;
        }

        private Snake GetSnake(int place) => Board.Snakes.Find(s => s.Head == place);
    }
}