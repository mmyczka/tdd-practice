using Tdd;

namespace TddTest
{
    public class RotationalCipherTest
    {

        [Theory]
        [InlineData("omg", 5, "trl")]
        [InlineData("o", 5, "t")]
        [InlineData("Cool", 26, "Cool")]
        [InlineData("The quick brown fox jumps over the lazy dog.", 13, "Gur dhvpx oebja sbk whzcf bire gur ynml qbt.")]
        [InlineData("Gur dhvpx oebja sbk whzcf bire gur ynml qbt.", 13, "The quick brown fox jumps over the lazy dog.")]
        public void Encrypt_returns_expected_ciphertext(string text, int shiftKey, string expected)
        {
            Assert.Equal(expected, RotationalCipher.Rotate(text,shiftKey));
        }
    }
}
