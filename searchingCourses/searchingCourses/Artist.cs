using System;
using System.Collections.Generic;

namespace searchingCourses
{
    public class Artist
    {
        public string name;
        internal List<string> songsTitles;
        public int wordCount;
        public int swearCount;

        public Artist(string name)
        {
            this.name = name;
        }

        public void CalculateSwerAndWordCount()
        {
            var pf = new ProfanityFinder();
            swearCount = 0;
            wordCount = 0;

            foreach ( var title in songsTitles)
            {
                var song = new Song(name, title);
                swearCount += pf.CountBadwords(song.lyrics);
                wordCount += song.CountWords();
            }

            Console.WriteLine("Swear count: "+ swearCount);
            Console.WriteLine("Word count: " + wordCount);
        }

        public void DisplayStatistic()
        {
            Console.WriteLine("Swear count: " + swearCount);
            Console.WriteLine("Word count: " + wordCount);
            int profanityIndex = wordCount / swearCount;
            Console.WriteLine("Dla Artysty:" + name + " co " + profanityIndex + " słowo to przekleństwo");
        }
        
    }
}
