namespace SnakesAndLadder
{

    public class Player
    {
        public string Name { get; }

        public Player()
        {
        }

        public Player(string name)
        {
            this.Name = name;
        }

        public int Place { get; set; } = 1;
    }
}