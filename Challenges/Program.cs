using System;
using System.Linq;

namespace Challenges
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Enumerable.Range(1, 100).ToList();
            input.ForEach(i => Console.Write(FizzBuzz.GetFizzBuzzValue(i) + '\n'));
            Console.ReadKey();
        }
    }
}