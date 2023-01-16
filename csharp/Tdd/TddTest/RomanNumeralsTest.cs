using Tdd;
namespace TddTest
{
    public class RomanNumeralsTest
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(90, "XC")]
        [InlineData(100, "C")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        [InlineData(1985, "MCMLXXXV")]

        public void Int_to_roman_numerals(int number, string expected)
        {
            Assert.Equal(expected, number.ToRoman());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4000)]
        public void Int_to_roman_numerals_out_of_range_exception(int number)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => number.ToRoman());
        }
    }
}
