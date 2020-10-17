using System;
using FluentAssertions;
using SnakesAndLadder;
using Xunit;

namespace SnakesAndLadders.Tests
{
    public class SampleTest
    {
        [Fact]
        public void Givenmaths_WhenIAddTwoAndThree_ThenIGetFive()
        {
            //given 
            var sample = new SampleClass();
            //when 
            var answer = sample.Add(2, 3);
            //then 
            answer.Should().Be(5);
        }

    }
}
