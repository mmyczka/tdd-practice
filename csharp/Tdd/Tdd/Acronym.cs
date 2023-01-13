using System.Text;

namespace Tdd
{
    public class Acronym
    {
        public static string Abbreviate(string input)
        {
            string[] words = input.Split(new char[] {'-', ' '}, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder acronym = new StringBuilder();

            foreach (string word in words)
            {
                string cleanWord = new(word.Where(c => char.IsLetter(c)).ToArray());
                acronym.Append(cleanWord[0]);
            }

            return acronym.ToString().ToUpper();
        }
    }
}