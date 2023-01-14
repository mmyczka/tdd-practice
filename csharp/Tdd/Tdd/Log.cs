using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd
{
    public static class Log
    {
        public static string SubstringAfter(this string str, string separator)
            => str.Split(separator).Last();

        public static string SubstringBetween(this string str, string start, string end)
            => str.SubstringAfter(start).Split(end).First();

        public static string Message(this string str)
            => str.SubstringAfter(": ");

        public static string LogLevel(this string str)
            => str.SubstringBetween("[", "]");
        
    }
}
