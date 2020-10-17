namespace SnakesAndLadders
{
    public class Snake
    {
        public int Head { get; }
        public int Tail { get; }

        public Snake(int head, int tail)
        {
            this.Head = head;
            this.Tail = tail;
        }
    }
}