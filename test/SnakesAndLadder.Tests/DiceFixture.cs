using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SnakesAndLadder.Tests
{
    public class DiceFixture
    {
        [Fact]
        public void GivenNewDice_WhenThrownHundredTimes_ThenGetsDifferentCountWithinOneAndSix()
        {
            //given 
            var dice = new Dice();
            var diceThrowFrequency = new Dictionary<int, int>();
            //when 
            for (int i = 0; i < 100; i++)
            {
                var diceThrow = dice.Throw();
                diceThrowFrequency[diceThrow] = diceThrowFrequency.ContainsKey(diceThrow) 
                                                    ? diceThrowFrequency[diceThrow] + 1 
                                                    : 1;
            }

            //then 
            diceThrowFrequency.Keys.Count.Should().Be(6);
            diceThrowFrequency.Keys.Should().BeEquivalentTo(1, 2, 3, 4, 5, 6);
        }
    }
}
