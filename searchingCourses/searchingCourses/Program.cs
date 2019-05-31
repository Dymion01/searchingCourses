using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace searchingCourses
{
    class Program
    {
        static void Main(string[] args)
        {
           //// var webcache = new WebCache();
           //// var eminem = new Artist("Eminem");
           // eminem.songsTitles = new List<string>()
           // {
           //     "Lucky You",
           //     "Lose Yourself",
           //     "Not Afraid"
           // };

            //eminem.CalculateSwerAndWordCount();

            //eminem.DisplayStatistic();


            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    public class WebCache
    {
        SQLiteConnection connection;
        public WebCache()
        {
            connection = new SQLiteConnection("Data Source=WebCache.sqlie;");
            connection.Open();

        }
        public void SaveInCache(string url,string data)
        {
            var sql= new SQLiteCommand()
        }
    }
}
