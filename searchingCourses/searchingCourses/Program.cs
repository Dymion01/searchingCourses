using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchingCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            var songlyrics = new SongLyrics("Shakira", "Nada");

            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    class SongLyrics
    {


        public SongLyrics(string artist, string title)
        {
            var browser = new System.Net.WebClient();
            var url = "https://api.lyrics.ovh/v1/" + artist + "/" + title; 
            var json = browser.DownloadString(url);
            Console.WriteLine(json);
        }
    }
}
