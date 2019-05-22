using Newtonsoft.Json;
using System;

namespace searchingCourses
{
    partial class SongLyrics
    {


        public SongLyrics(string artist, string title)
        {
            var browser = new System.Net.WebClient();
            var url = "https://api.lyrics.ovh/v1/" + artist + "/" + title; 
            var json = browser.DownloadString(url);
            var answer = JsonConvert.DeserializeObject<LyricsOvhAnswer>(json);
            Console.WriteLine(answer.lyrics);

        }
    }
}
