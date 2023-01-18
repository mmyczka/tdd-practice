namespace Tdd
{
    public class PhoneNumber
    {
        public static (bool, bool, string) Analyze(string number)
        {
            string[] elements = number.Split('-');
            return (elements[0] == "212", elements[1] == "555", elements[2]);
        }

        public static bool IsFake((bool isCity, bool isFake, string Lokal) input)
            => input.isFake;
    }
}