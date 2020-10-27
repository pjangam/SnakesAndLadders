using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadder
{
    public class SkipOnPrimeNumberStrategy : IGameStrategy
    {
        private Dictionary<string, bool> _shouldSkip;
        public SkipOnPrimeNumberStrategy(IEnumerable<Player> _players)
        {
            _shouldSkip = _players.Select(p => p.Id).ToDictionary(x => x, x => false);
        }
        public Player GetNextPlayer(CircularLinkedList<Player> _players)
        {
            if (isPrime(_players.Current.Place))
            {
                _shouldSkip[_players.Current.Id] = true;
            }
            _players.MoveNext();
            if (_shouldSkip[_players.Current.Id])
            {
                _shouldSkip[_players.Current.Id]=false;
                _players.MoveNext(); 
            }

            return _players.Current;
        }

        private List<int> _primePlaces = new List<int>
        {
            2, 3, 5, 7,
            11, 13, 17, 19,
            23, 29,
            31, 37,
            41, 43, 47,
            53, 59,
            61, 67,
            71, 73, 79,
            83, 89,
            97
        };
        private bool isPrime(int place) => _primePlaces.Contains(place);
    }
}
