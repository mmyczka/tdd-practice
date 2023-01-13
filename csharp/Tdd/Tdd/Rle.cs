namespace Tdd
{
    public class Rle
    {
        public static string Encode(string text)
        {
            string code = "";
            char current = text[0];
            int cnt = 0;

            foreach(char c in text)
            {
                if (c == current)
                    cnt++;
                else
                {
                    
                    code += cnt == 1 ? current : (cnt.ToString() + current);
                    current = c;
                    cnt = 1;
                }
            }
            code += cnt == 1 ? current : (cnt.ToString() + current);
            return code;
        }

        public static string Decode(string code)
        {
            string text = "";
            int cnt = 0;

            foreach(var c in code)
            {
                if (Char.IsNumber(c))
                    cnt = cnt * 10 + (c - '0');
                else
                {
                    text += new string(c, cnt == 0 ? 1 : cnt);
                    cnt = 0;
                }

            }

            return text;
        }
    }
}