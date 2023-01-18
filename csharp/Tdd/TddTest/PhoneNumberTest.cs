using Tdd;

namespace TddTest
{
    public class PhoneNumberTest
    {
        [Theory]
        [InlineData("123-123-1234", false, false, "1234")]
        [InlineData("212-555-4321", true, true, "4321")]
        public void Analyze_phone_number(string number, bool IsCity, bool IsFake, string Local)
        {
            (bool, bool, string) expected = (IsCity, IsFake, Local);
            Assert.Equal(expected, PhoneNumber.Analyze(number));
        }

        [Theory]
        [InlineData(false, false, "1234", false)]
        [InlineData(true, true, "4321", true)]
        public void Analyze_if_phone_number_is_fake(bool IsCity, bool IsFake, string Local, bool expected)
        {
            (bool, bool, string) input = (IsCity, IsFake, Local);
            Assert.Equal(expected, PhoneNumber.IsFake(input));
        }

    }
}
 