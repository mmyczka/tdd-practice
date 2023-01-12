using Tdd;

namespace TddTest
{
    public class IsogramTest
    {
        [Theory]
        [InlineData("isogram", true)]
        [InlineData("isograms", false)]
        [InlineData("isogram-bc-de", true)]
        public void Check_if_input_is_isogram(string input, bool result)
        {
            Assert.Equal(result, Isogram.IsIsogram(input));
        }
    }
}
