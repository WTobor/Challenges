using System.Collections.Generic;
using Xunit;

namespace Challenges.Tests
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(new[] {3, 6, 9, 12, 18, 21})]
        public void Modulo3IsFizz(IEnumerable<int> input)
        {
            foreach (var number in input)
                Assert.Equal(FizzBuzzValue.Fizz.ToString(), FizzBuzz.GetFizzBuzzValue(number));
        }

        [Theory]
        [InlineData(new[] {5, 10, 20, 25, 35, 40})]
        public void Modulo5IsBuzz(IEnumerable<int> input)
        {
            foreach (var number in input)
                Assert.Equal(FizzBuzzValue.Buzz.ToString(), FizzBuzz.GetFizzBuzzValue(number));
        }

        [Theory]
        [InlineData(new[] {15, 30, 45, 60, 75, 90})]
        public void Modulo3And5IsFizzBuzz(IEnumerable<int> input)
        {
            foreach (var number in input)
                Assert.Equal($"{FizzBuzzValue.Fizz.ToString()}{FizzBuzzValue.Buzz.ToString()}",
                    FizzBuzz.GetFizzBuzzValue(number));
        }

        [Theory]
        [InlineData(new[] {1, 2, 4, 7, 8, 11})]
        public void NoModuloIsNumber(IEnumerable<int> input)
        {
            foreach (var number in input) Assert.Equal(number.ToString(), FizzBuzz.GetFizzBuzzValue(number));
        }
    }
}