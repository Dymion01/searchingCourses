using Newtonsoft.Json;
using SearchingCurses;
using System;

namespace searchingCourses
{
    partial class Song
    {
        public string artist;
        public string title;
        public string lyrics;



        public Song(string artist, string title)
        {
            //var browser = new System.Net.WebClient();
            var url = "https://api.lyrics.ovh/v1/" + artist + "/" + title;
            //var json = browser.DownloadString(url);
            var json = WebCache.GetOrDownload(url);
            var answer = JsonConvert.DeserializeObject<LyricsOvhAnswer>(json);
            lyrics = answer.lyrics;
            this.artist = artist;
            this.title = title;
            Console.WriteLine("Pobrano: " + artist + " - " + title + " ("+CountWords()+" słów)");
        }
            public int CountWords()
            {
                return lyrics.Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries).Length;
            }
        
    }
}
