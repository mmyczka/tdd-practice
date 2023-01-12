namespace Tdd
{
    public class Isogram
    {
        public static bool IsIsogram(string input)
        {
            HashSet<char> characters = new HashSet<char>();

            foreach (char c in input.ToLower())
            {
                if (c == ' ' || c == '-') continue;
                if (!characters.Add(c))
                    return false;
            }
            return true;
        }
    }
}