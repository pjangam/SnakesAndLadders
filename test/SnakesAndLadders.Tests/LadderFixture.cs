using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class LadderFixture
    {
        [Fact]
        public async Task GivenGame_WhenUserCreateLadderWithValidValues_ThenLadderInstanceCreated()
        {
            //given 

            //when 
            var ladder = new SnakesAndLadders.Ladder(5, 25);
            //then 
            ladder.Start.Should().Be(5);
            ladder.End.Should().Be(25);
        }

        [Fact]
        public async Task GivenLadderStartLow_WhenUserCreateLadder_ThenLadderInstanceCreated()
        {
            //given 

            //when 
            Action act = () => new SnakesAndLadders.Ladder(0, 5);
            //then 
            var err = act.Should().ThrowExactly<ArgumentOutOfRangeException>().And;
            err.ActualValue.Should().Be(0);
            err.Message.Should().StartWith("Ladder start should be more than 0");
        }

        [Fact]
        public async Task GivenEndAboveBoard_WhenUserCreateLadder_ThenLadderInstanceCreated()
        {
            //given 

            //when 
            Action act = () => new SnakesAndLadders.Ladder(57, 105);
            //then 
            var err = act.Should().ThrowExactly<ArgumentOutOfRangeException>().And;
            err.ActualValue.Should().Be(105);
            err.Message.Should().StartWith("Ladder end should be less than 100");
        }

        [Fact]
        public async Task GivenInverseLadder_WhenUserCreateLadder_ThenLadderInstanceCreated()
        {
            //given 

            //when 
            Action act = () => new SnakesAndLadders.Ladder(25, 5);
            //then 
            var err = act.Should().ThrowExactly<ArgumentException>().And;
            err.Message.Should().StartWith("Ladder end has to be above start");
        }
    }
}
