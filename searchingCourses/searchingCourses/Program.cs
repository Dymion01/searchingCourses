using System;
using System.IO;
using System.Text.RegularExpressions;

namespace searchingCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            var songLyrics = new SongLyrics("Eminem", "Without me");
            var profanityFinder = new ProfanityFinder();

            var Censored = profanityFinder.Censored(songLyrics.lyrics);

            Console.WriteLine(Censored);
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    internal class ProfanityFinder
    {
        private string[] badWords;

        public ProfanityFinder() 
        {
            var dictFile = File.ReadAllText("../profanities.txt");
            dictFile = dictFile.Replace("*", "");
            dictFile = dictFile.Replace("(", "");
            dictFile = dictFile.Replace(")", "");
            badWords = dictFile.Split(new[] {"\",\""}, StringSplitOptions.None);
           
        }

        public string Censored(string text)
        {
            foreach (var word in badWords)
            {
                text = RemoveBadWord(text, word);

            }
            return text;
        }

        private static string RemoveBadWord(string text, string word)
        {
            string pattern = "\\b"+word+"\\b";
            return Regex.Replace(text, pattern, "___", RegexOptions.IgnoreCase);
        }
    }
}
