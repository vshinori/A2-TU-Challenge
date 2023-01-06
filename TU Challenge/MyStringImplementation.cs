using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static bool IsNullEmptyOrWhiteSpace(string s)
        {
            if (s == null)
                return true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    return false;
            }
            return true;
        }


        public static string MixString(string a, string b)
        {
            var tuples = a.Zip(b, (c1, c2) => new Tuple<char, char>(c1, c2));
            var result = tuples.SelectMany(t => new char[] { t.Item1, t.Item2 }).ToArray();
            return new string(result);
        }


        public static string ToLowerCase(string str)
        {
            char[] result = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c >= 'A' && c <= 'Z')
                    c = (char)(c + ('a' - 'A'));
                result[i] = c;
            }
            return new string(result);
        }

        public static string Voyelles(string str)
        {
            var result = str.Where(c => "AEIOUYaeiouy".Contains(c)).ToArray();
            return new string(result);
        }

        public static string Reverse(string str)
        {
            char[] result = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                result[i] = str[str.Length - i - 1];
            }
            return new string(result);
        }

        public static string BazardString(string str)
        {
            char[] result = new char[str.Length];
            int j = 0;
            for (int i = 0; i < str.Length; i += 2)
                result[j++] = str[i];
            for (int i = 1; i < str.Length; i += 2)
                result[j++] = str[i];
            return new string(result);
        }
    }
}
