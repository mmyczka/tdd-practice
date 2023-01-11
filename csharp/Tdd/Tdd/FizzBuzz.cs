namespace Tdd
{
    public class FizzBuzz
    {
        public static string GetOutput(int number)
        {
            string? result = null;
            if (number % 3 == 0) result += "Fizz";
            if (number % 5 == 0) result += "Buzz";
            return result ?? number.ToString();
        }
    }
}