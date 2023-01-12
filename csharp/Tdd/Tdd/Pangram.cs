namespace Tdd
{
    public class Pangram
    {
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public static bool IsPangram(string input) 
            => alphabet.All(x => input.ToLower().Contains(x));
    }
}