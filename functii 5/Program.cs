 using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "This is a test phrase.";
        Console.WriteLine(FindWord(text, "this", true));
        Console.Read();
    }

    static bool FindWord(string text, string word, bool caseSensitive = false)
    {
        string[] words = text.Split(' ', ',', '.', '!', '?');
        for (int i = 0; i < words.Length; i++)
        {
            bool bFound = caseSensitive ?
                words[i].Equals(word) :
                words[i].Equals(word, StringComparison.CurrentCultureIgnoreCase);

            if (bFound)
                return true;
        }
        return false;
    }

}
