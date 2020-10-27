using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadders
{

    public class Game : IGame
    {
        private IDice _dice;
        private CircularLinkedList<Player> _players;
        private IGameStrategy _gameStrategy;

        public Game(IList<Player> players, IDice dice, Board board, IGameStrategy gameStrategy)
        {
            _dice = dice;
            _players = new CircularLinkedList<Player>(players);
            _gameStrategy = gameStrategy;

            Board = board;
            Players = players;
        }

        public IEnumerable<Player> Players
        {
            get;
        }
        public Board Board { get; }
        public Player CurrentPlayer
        {
            get => _players.Current;
        }

        public int Play()
        {
            var diceThrow = _dice.Throw();
            CurrentPlayer.Place = Board.GetNextPosition(diceThrow, CurrentPlayer.Place);
            _gameStrategy.GetNextPlayer(_players);
            return diceThrow;
        }

    }
}