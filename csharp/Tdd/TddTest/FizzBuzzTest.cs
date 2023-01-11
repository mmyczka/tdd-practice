using Tdd;

namespace TddTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzzExpectedResult(int number, string expected)
        {
           Assert.Equal(expected, FizzBuzz.GetOutput(number));
        }
    }
}