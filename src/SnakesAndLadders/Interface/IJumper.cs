namespace SnakesAndLadders
{
    public interface IJumper
    {
        int Start { get; }
        int End { get; }

        int Jump();
    }
}