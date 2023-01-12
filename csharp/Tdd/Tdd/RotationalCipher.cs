namespace Tdd
{
    public class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
            => new(text.Select(c => RotateChar(c, shiftKey)).ToArray());

        private static char RotateChar(char c, int shiftKey)
        {
            if (!char.IsLetter(c))
                return c;            
                
            char baseChar = char.IsUpper(c) ? 'A' : 'a';                
            return (char)((c - baseChar + shiftKey) % 26 + baseChar);
        }
    }
}