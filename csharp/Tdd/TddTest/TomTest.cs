using Tdd;

namespace TddTest
{
    public  class TomTest
    {
        [Theory]
        [InlineData("How are you?", "Sure.")]
        [InlineData("I'M FINE", "Whoa, chill out!")]
        [InlineData("CAN YOU OPEN THE DOOR?", "Calm down, I know what I'm doing!")]
        [InlineData("", "Fine. Be that way!")]
        [InlineData("Hello.", "Whatever.")]
        [InlineData("Okay if like my  spacebar  quite a bit?   ", "Sure.")]
        public void Test_Tom_responses(string input, string expected)
        {
            Assert.Equal(expected, Tom.Response(input));
        }
    }
}
