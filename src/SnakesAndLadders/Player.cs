using System;

namespace SnakesAndLadders
{

    public class Player
    {
        public string Id { get; }


        public Player(string id = null)
        {
            this.Id = id ?? Guid.NewGuid().ToString();
        }

        public int Place { get; set; } = 1;
    }
}