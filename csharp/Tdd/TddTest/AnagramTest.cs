using Tdd;

namespace TddTest
{
    public class AnagramTest
    {
        [Fact]
        public void Check_if_given_words_are_anagrams_for_stone()
        {
            string target = "stone";
            string[] candidates = { "stone", "tones", "banana", "tons", "notes", "Seton" };
            string[] expected = { "tones", "notes", "Seton" };

            var anagram = new Anagram(target);

            Assert.Equal(expected, anagram.FindAnagrams(candidates));
        }

        [Fact]
        public void Check_if_given_words_are_anagrams_for()
        {
            var candidates = new[] { "cashregister", "carthorse", "radishes" };
            var anagram = new Anagram("Orchestra");
            var expected = new[] { "carthorse" };
            Assert.Equal(expected, anagram.FindAnagrams(candidates));
        }
    }
}
