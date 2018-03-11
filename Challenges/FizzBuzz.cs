namespace Challenges
{
    /// INPUT
    /// 1, 2, 3, 4, 5, ..., 95, 96, 97, 98, 99, 100
    /// LOGIC
    /// if number % 3 is 0, then return Fizz
    /// if number %5 is 0, then return Buzz
    /// if number % 3 and number %5 is 0, then return FizzBuzz
    /// else return number
    /// OUTPUT
    /// 1, 2, Fizz, 4, Buzz, 6, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, ...

    public enum FizzBuzzValue
    {
        Fizz,
        Buzz
    }

    public static class FizzBuzz
    {
        public static string GetFizzBuzzValue(int number)
        {
            var result = "";
            if (number % 3 == 0)
                result += FizzBuzzValue.Fizz.ToString();
            if (number % 5 == 0)
                result += FizzBuzzValue.Buzz.ToString();
            else if (number % 3 != 0 && number % 5 != 0)
                result = number.ToString();
            return result;
        }
    }
}