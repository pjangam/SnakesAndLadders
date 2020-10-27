using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadders
{
    public class Game
    {
        private IDice _dice;
        private int _currentPlayerIndex;
        private IList<Player> _players;

        public Game(IList<Player> players, IDice dice, Board board)
        {
            _dice = dice;
            _players = players;
            Board = board;
            _currentPlayerIndex = 0;
            CurrentPlayer = Players.ToList()[0];
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
            CurrentPlayer = GetNextPlayer();
            return diceThrow;
        }

        private Player GetNextPlayer()
        {
            _currentPlayerIndex++;
            if (_currentPlayerIndex == Players.Count())
            {
                _currentPlayerIndex = 0;
            }
            return Players.ToList()[_currentPlayerIndex];
        }

        private ISnake GetSnake(int place) => Board.Snakes.FirstOrDefault(s => s.Head == place);
    }
}