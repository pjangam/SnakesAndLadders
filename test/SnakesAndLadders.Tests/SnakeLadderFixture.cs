using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
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

        [Fact]
        public void GivenNewBoardWithOneUser_WhenGamePlayed_ThenUserIsAdvanced()
        {
            //given 
            var gameBuilder = new GameBuilder();
            var player = gameBuilder.AddPlayer();
            var game = gameBuilder.Build();
            //when 
            var diceThrow = game.Play();
            //then 
            game.Players[0].Place.Should().Be(diceThrow + 1);
        }

        [Fact]
        public void GivenPlayerIsAt70_WhenGameRolls4_ThenPlaceIs74()
        {
            //given 
            //PlayerIsAt97
            var gameBuilder = new GameBuilder();
            var player = gameBuilder.AddPlayer();
            player.Place = 70;
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Throw()).Returns(4);
            gameBuilder.SetDice(dice.Object);
            var game = gameBuilder.Build();
            //when 
            game.Play();
            //then 
            game.Players[0].Place.Should().Be(74);
        }

        [Fact]
        public void GivenPlayerIsAt97_WhenGameRolls4_ThenPlaceIsUnchanged()
        {
            //given 
            //PlayerIsAt97
            var gameBuilder = new GameBuilder();
            var player = gameBuilder.AddPlayer();
            player.Place = 97;
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Throw()).Returns(4);
            gameBuilder.SetDice(dice.Object);
            var game = gameBuilder.Build();
            //when 
            game.Play();
            //then 
            game.Players[0].Place.Should().Be(97);
        }
    }

}
