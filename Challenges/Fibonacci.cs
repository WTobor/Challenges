using System;

namespace Challenges
{
    /// INPUT
    /// 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10...
    /// LOGIC
    /// if number is 0, then return 0
    /// if number is 1 or 2, then return 1
    /// if number is bigger than 2, then return Fib(n-1) + Fib(n-2)
    /// OUTPUT
    /// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55...
    public static class Fibonacci
    {
        public static int GetFibValue(int value)
        {
            if (value < 0)
                throw new FormatException();
            if (value == 0)
                return 0;
            if (value < 2)
                return 1;
            return GetFibValue(value - 1) + GetFibValue(value - 2);
        }
    }
}