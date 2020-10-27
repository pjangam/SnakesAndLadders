using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace SnakesAndLadder.Tests
{
    public class CrookedDiceFixture
    {
        [Fact]
        public void GivenCrookedDice_WhenThrownHundredTimes_ThenGetsDifferentEvenCountWithinOneAndSix()
        {
            //given 
            var dice = new CrookedDice();
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
            diceThrowFrequency.Keys.Count.Should().Be(3);
            diceThrowFrequency.Keys.Should().BeEquivalentTo(2, 4, 6);
        }
    }

}
