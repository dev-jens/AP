using System;

namespace REcursief_zoek_woord_in_zin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static object exactMatch(object text, object pat, object text_index, object pat_index)
        {
            if (text_index == text.Count && pat_index != pat.Count)
            {
                return 0;
            }
            // Else If last character of pattern reaches
            if (pat_index == pat.Count)
            {
                return 1;
            }
            if (text[text_index] == pat[pat_index])
            {
                return exactMatch(text, pat, text_index + 1, pat_index + 1);
            }
            return 0;
        }

        // This function returns true if 'text' contain 'pat'
        public static object contains(object text, object pat, object text_index, object pat_index)
        {
            // If last character of text reaches
            if (text_index == text.Count)
            {
                return 0;
            }
            // If current characters of pat and text match
            if (text[text_index] == pat[pat_index])
            {
                if (exactMatch(text, pat, text_index, pat_index))
                {
                    return 1;
                }
                else
                {
                    return contains(text, pat, text_index + 1, pat_index);
                }
            }
            // If current characters of pat and tex don't match
            return contains(text, pat, text_index + 1, pat_index);
        }

    }
}
