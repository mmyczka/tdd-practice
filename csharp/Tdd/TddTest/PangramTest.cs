using Tdd;

namespace TddTest
{
    public class PangramTest
    {
        [Fact]
        public void Check_if_text_is_a_pangram()
        {
            var input = "The quick brown fox jumps over the lazy dog.";
            Assert.True(Pangram.IsPangram(input));
        }

        [Fact]
        public void Check_if_text_is_a_pangram_too()
        {
            var input = "The quick brown fox jumps over The lazy dog.";
            Assert.True(Pangram.IsPangram(input));
        }

        [Fact]
        public void Check_if_text_is_not_a_panagram()
        {
            var input = "abc";
            Assert.False(Pangram.IsPangram(input));
        }
    }
}
