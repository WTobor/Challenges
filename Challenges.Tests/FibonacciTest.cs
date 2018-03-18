using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Challenges.Tests
{
    public class FibonacciTest
    {
        private readonly int[] _expectedResult =
        {
            2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181
        };


        [Fact]
        public void FibonacciFrom0()
        {
            var result = Fibonacci.GetFibValue(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void FibonacciFrom1()
        {
            var result = Fibonacci.GetFibValue(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void FibonacciFrom2()
        {
            var result = Fibonacci.GetFibValue(2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void FibonacciFrom3()
        {
            var result = Fibonacci.GetFibValue(3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void FibonacciFromNegative()
        {
            var result = new List<int>();
            foreach (var input in Enumerable.Range(3, 17))
                result.Add(Fibonacci.GetFibValue(input));
            Assert.Equal(_expectedResult.ToList(), result);
        }
    }
}