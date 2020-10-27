namespace SnakesAndLadders
{
    public interface IJumper
    {
        int Head { get; }
        int Tail { get; }

        int Jump();
    }
}