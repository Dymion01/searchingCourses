using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace searchingCourses
{
    internal class ProfanityFinder
    {
        private string[] badWords;
        
        public ProfanityFinder() 
        {
            var dictFile = File.ReadAllText("profanities.txt");
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
        public int CountBadwords(string lyrics)
        {
            int badWordsAmount = 0;
            foreach (var word in badWords)
                    badWordsAmount += CalcOccurencesOfWord(word, lyrics);
            return badWordsAmount;
        }

        public Dictionary<string, int> FindBadWords(string lyrics)
        {
            var dict = new Dictionary<string, int>();
            foreach (var word in badWords)
            {
                int occurencesOfWord = CalcOccurencesOfWord(word, lyrics);
                if (occurencesOfWord > 0)
                {
                    dict[word] = occurencesOfWord;
                }
            }
            return dict;
        }

        private int CalcOccurencesOfWord(string word, string lyrics)
        {
            string pattern = "\\b" + word + "\\b";
            return
            Regex.Matches(lyrics, pattern).Count;
        }

        private static string RemoveBadWord(string text, string word)
        {
            string pattern = "\\b"+word+"\\b";
            return Regex.Replace(text, pattern, "___", RegexOptions.IgnoreCase);
        }


        public string GetBadWordsSummary(Song song)
        {
            var summary = "";
            var badWordsAmount = FindBadWords(song.lyrics);
            foreach (var word in badWordsAmount.OrderBy(word=>word.Value))
            {
                summary = summary + " " +word.Key + " " + word.Value +"\n";
            }
            return summary;
        }

    }

}
