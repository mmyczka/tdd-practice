using Tdd;

namespace TddTest
{
    public class RleTest
    {
        [Fact]
        public void Encode_text_using_rle()
        {
            var text = "AABCCCDEEEE";
            var expected = "2AB3CD4E";

            Assert.Equal(expected, Rle.Encode(text));
        }

        [Fact]
        public void Decode_text_using_rle()
        {
            var text = "2AB3CD4E";
            var expected = "AABCCCDEEEE";

            Assert.Equal(expected, Rle.Decode(text));
        }
    }
}
