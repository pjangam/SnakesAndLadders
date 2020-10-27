using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using SnakesAndLadder;
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
            var player = gameBuilder.AddPlayer(new Player());
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
            var player = gameBuilder.AddPlayer(new Player());
            var game = gameBuilder.Build();
            //when 
            var diceThrow = game.Play();
            //then 
            game.Players.ToList()[0].Place.Should().Be(diceThrow + 1);
        }

        [Fact]
        public void GivenPlayerIsAt70_WhenGameRolls4_ThenPlaceIs74()
        {
            //given 
            var gameBuilder = new GameBuilder();
            var player = new Player()
            {
                Place = 70
            };
            gameBuilder.AddPlayer(player);
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Throw()).Returns(4);
            gameBuilder.SetDice(dice.Object);
            var game = gameBuilder.Build();

            //when 
            game.Play();

            //then 
            game.Players.ToList()[0].Place.Should().Be(74);
        }

        [Fact]
        public void GivenPlayerIsAt97_WhenGameRolls4_ThenPlaceIsUnchanged()
        {
            //given 
            //PlayerIsAt97
            var gameBuilder = new GameBuilder();
            var player = new Player()
            {
                Place = 97
            };
            gameBuilder.AddPlayer(player);
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Throw()).Returns(4);
            gameBuilder.SetDice(dice.Object);
            var game = gameBuilder.Build();

            //when 
            game.Play();

            //then 
            game.Players.ToList()[0].Place.Should().Be(97);
        }

        [Fact]
        public void GivenGameHasSnakeAtFourteen_WhenUserReachesFourteen_ThenUserShouldMoveToSeven()
        {
            //given 
            var gameBuilder = new GameBuilder();
            var player = new Player
            {
                Place = 10
            };
            gameBuilder.AddPlayer(player);
            var snake = new Snake(14, 7);
            gameBuilder.AddSnake(snake);
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Throw()).Returns(4);
            gameBuilder.SetDice(dice.Object);
            var game = gameBuilder.Build();

            //when 
            var diceThrow = game.Play();

            //then 
            game.Players.ToList()[0].Place.Should().Be(7);
        }


        [Fact]
        public async Task GivenPlayerHitsGreensSnakes_WhenPlayerAgainHitsSameSnake_ThenSnakeIsPowerless()
        {
            //given 
            var gameBuilder = new GameBuilder();
            var player = new Player
            {
                Place = 10
            };
            gameBuilder.AddPlayer(player);
            var snake = new GreenSnake(14, 10);
            gameBuilder.AddSnake(snake);
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Throw()).Returns(4);
            gameBuilder.SetDice(dice.Object);
            var game = gameBuilder.Build();
            var diceThrow = game.Play();

            //when 
            diceThrow = game.Play();

            //then 
            player.Place.Should().Be(14);
        }

        //[Fact]
        public async Task GivenPlayer_WhenLandsOnPrimeNumber_ThenPlayerSkipsATurn()
        {
            //given 
            var gameBuilder = new GameBuilder();
            var player1 = new Player("player1")
            {
                Place = 10
            };
            var player2 = new Player("player2")
            {
                Place = 11
            };
            gameBuilder.AddPlayer(player1);
            gameBuilder.AddPlayer(player2);
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Throw()).Returns(3);
            gameBuilder.SetDice(dice.Object);
            var game = gameBuilder.Build();
            //when
            game.CurrentPlayer.Name.Should().Be(player1.Name);
            game.Play();
            game.CurrentPlayer.Name.Should().Be(player2.Name);
            game.Play();
            //game.CurrentPlayer.Should().Be(player2);
            // game.Play();
            // game.CurrentPlayer.Should().Be(player1);
            //then 
        }
    }

}
