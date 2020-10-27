using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadders
{
    public class Game
    {
        private IDice _dice;
        private IList<Player> _players;
        private IGameStrategy _gameStrategy;

        public Game(IList<Player> players, IDice dice, Board board, IGameStrategy gameStrategy)
        {
            _dice = dice;
            _players = players;
            Board = board;
            CurrentPlayer = _players[0];
            _gameStrategy = gameStrategy;
        }
        public IEnumerable<Player> Players
        {
            get
            {
                return _players;
            }
        }
        public Board Board { get; }
        public Player CurrentPlayer
        {
            get;
            private set;
        }

        public int Play()
        {
            var diceThrow = _dice.Throw();
            CurrentPlayer.Place = Board.GetNextPosition(diceThrow, CurrentPlayer.Place);
            CurrentPlayer = _gameStrategy.GetNextPlayer();
            return diceThrow;
        }



        private ISnake GetSnake(int place) => Board.Snakes.FirstOrDefault(s => s.Head == place);
    }
}