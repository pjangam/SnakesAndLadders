using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class SnakeLadderFixture
    {
        [Fact]
        public void GivenBoardWithOneUser_WhenNewGameCreated_ThenUserPlaceShouldBeOne()
        {
            //given 
            var gameBuilder = new GameBuilder();
            var player = gameBuilder.AddPlayer();
            //when 
            var game = gameBuilder.Build();
            //then 
            player.Place.Should().Be(1);
        }
    }

}
