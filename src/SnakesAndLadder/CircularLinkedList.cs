using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SnakesAndLadder
{
    public class CircularLinkedList<T> : IEnumerator<T>
    {
        private List<T> _data;
        private int _currentIndex;

        public CircularLinkedList(IEnumerable<T> data)
        {
            _data = data.ToList();
            _currentIndex = 0;
        }
        public T Current => _data[_currentIndex];

        object IEnumerator.Current => _data[_currentIndex];

        public void Dispose() { }

        public bool MoveNext()
        {
            _currentIndex = IsLast() ? 0 : _currentIndex + 1;
            return true;
        }

        private bool IsLast() => _currentIndex == _data.Count - 1;

        public void Reset() => _currentIndex = 0;
    }
}
