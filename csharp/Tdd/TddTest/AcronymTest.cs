using Tdd;

namespace TddTest
{
    public class AcronymTest
    {
        [Theory]
        [InlineData("As Soon As Possible", "ASAP")]
        [InlineData("In My Opinion", "IMO")]
        [InlineData("Liquid-crystal display", "LCD")]
        [InlineData("Thank Mick It's Today!", "TMIT")]
        [InlineData("I Like _Ice-Cream", "ILIC")]
        public void GenerateProperAcronym(string input, string expected)
        {
            Assert.Equal(expected, Acronym.Abbreviate(input));
        }
    }
}
