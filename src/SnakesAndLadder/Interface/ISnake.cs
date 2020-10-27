namespace SnakesAndLadder
{
    public interface ISnake
    {
        int Head { get; }
        int Tail { get; }

        int Eat();
    }
}