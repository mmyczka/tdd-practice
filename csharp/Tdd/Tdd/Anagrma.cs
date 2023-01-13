namespace Tdd
{
    public class Anagram
    {
        private string _word;
        private string _wordSorted;

        public Anagram(string word)
        {
            _word = word.ToLower();
            _wordSorted = SortedWord(_word);
        }

        public string[] FindAnagrams(string[] candidates)
            => candidates.Where(x => IsAnagram(x.ToLower())).ToArray();

        private bool IsAnagram(string candidate)
            => SortedWord(candidate) == _wordSorted && IsDifferentFromBase(candidate);

        private bool IsDifferentFromBase(string candidate)
            => candidate != _word;

        private static string SortedWord(string word)
            => String.Concat(word.OrderBy(c => c)); 
    }
}