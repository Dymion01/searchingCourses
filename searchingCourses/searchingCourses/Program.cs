using System;
using System.IO;

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
            badWords = dictFile.Split(new[] {"\",\""}, StringSplitOptions.None);
           
        }

        public string Censored(string text)
        {
            foreach (var word in badWords)
            {
                text = text.Replace(" " + word + " ", " ___ ");
                
            }
            return text;
        }
    }
}
