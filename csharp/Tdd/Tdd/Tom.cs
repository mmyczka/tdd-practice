namespace Tdd
{
    public class Tom
    {
        public static string Response(string input)
        {
            input = input.Trim();

            if (IsYelling(input) && input.EndsWith('?'))
                return "Calm down, I know what I'm doing!";

            if(IsYelling(input))
                return "Whoa, chill out!";

            if (input.EndsWith('?'))
                return "Sure.";

            if (string.IsNullOrWhiteSpace(input))
                return "Fine. Be that way!";

            return "Whatever.";
        }

        private static bool IsYelling(string input)
            => input == input.ToUpper()
            && input.Any(c => char.IsLetter(c));
    }
}