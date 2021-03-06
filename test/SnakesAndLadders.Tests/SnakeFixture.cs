using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class SnakeFixture
    {
        [Fact]
        public void GivenGame_WhenUserCreateSnakeWithValidValues_ThenSnakeInstanceCreated()
        {
            //given 

            //when 
            var snake = new Snake(25, 5);
            //then 
            snake.Head.Should().Be(25);
            snake.Tail.Should().Be(5);
        }

        [Fact]
        public void GivenSnakeHeadHigh_WhenUserCreateSnake_ThenSnakeInstanceCreated()
        {
            //given 

            //when 
            Action act = () => new Snake(100, 5);
            //then 
            var err = act.Should().ThrowExactly<ArgumentOutOfRangeException>().And;
            err.ActualValue.Should().Be(100);
            err.Message.Should().StartWith("Snake head should be less than 100");
        }

        [Fact]
        public void GivenTailNegative_WhenUserCreateSnake_ThenSnakeInstanceCreated()
        {
            //given 

            //when 
            Action act = () => new Snake(10, -5);
            //then 
            var err = act.Should().ThrowExactly<ArgumentOutOfRangeException>().And;
            err.ActualValue.Should().Be(-5);
            err.Message.Should().StartWith("Snake tail should be greater than 1");
        }

        [Fact]
        public void GivenInverseSnake_WhenUserCreateSnake_ThenSnakeInstanceCreated()
        {
            //given 

            //when 
            Action act = () => new Snake(5, 25);
            //then 
            var err = act.Should().ThrowExactly<ArgumentException>().And;
            err.Message.Should().StartWith("Snake tail has to be below head");
        }
    }
}
