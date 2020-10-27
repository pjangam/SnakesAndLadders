// using System;
// using System.Collections.Generic;

// namespace SnakesAndLadder
// {
//     public class SkipOnPrimeNumberStrategy : IGameStrategy
//     {
//         private CircularLinkedList<Player> _players;
//         public SkipOnPrimeNumberStrategy(IList<Player> players)
//         {
//             _players = new CircularLinkedList<Player>(players);
//         }

//         public Player GetNextPlayer()
//         {
//             _players.MoveNext();

//             return _players.Current;
//         }
//     }
// }
