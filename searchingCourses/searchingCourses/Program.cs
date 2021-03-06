﻿using SearchingCurses;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace searchingCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Autora");
            string Author = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Podaj piosenki (np. piosenka1, piosenka2,...)");
            string  song = Convert.ToString(Console.ReadLine());
            string[] separator = new string[] { ", "};
            string[] songs = song.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            
            var author = new Artist(Author);
            author.songsTitles =   songs;
                
            author.CalculateSwerAndWordCount();
            author.DisplayStatistic();
            
            Console.WriteLine("Done.");
            Console.ReadKey();
            //          var eminem = new Artist("Eminem");
            //         eminem.songsTitles = new List<string>()
            //          {
            //              "Lucky You",
            //              "Lose Yourself",
            //              "Not Afraid",
            //              "Rap God",
            //              "Fack",
            //              "The Ringer",
            //                 "Greatest",
            //                "Lucky You",
            //                "ajsjdf",
            //                 "Normal",
            //                  "Stepping Stone",
            //                  "Not Alike",
            //                  "Kamikaze",
            //                  "Fall",
            //                "Nice Guy",
            //                  "Good Guy",
            //                  "Venom",
            //                  "3 Verses",
            //"313                                                        ",
            //"313 — Infinite                                             ",
            //"8 Mile                                                     ",
            //"8 Mile Freestyle                                           ",
            //"8 Mile Freestyle Pt.ii Vs Lotto                            ",
            //"8 Mile Freestyle Pt.iii Vs Papa Doc                        ",
            //"8 Mile Freestyle Vs Lickety Split                          ",
            //"8 Mile Road                                                ",
            //"97 Bonnie And Clyde                                        ",
            //"A Few Different Frestyles                                  ",
            //"Addicted                                                   ",
            //"Amityville                                                 ",
            //"Any Man                                                    ",
            //"As The World Turns                                         ",
            //"Ass Like That                                              ",
            //"B—rabbit On The Roof Top                                   ",
            //"B—rabbit Vs. Diffusion                                     ",
            //"B—rabbit Vs. Marv One                                      ",
            //"Baby Come Back                                             ",
            //"Back Stabber                                               ",
            //"Backstabber                                                ",
            //"Bad Guys Always Die                                        ",
            //"Bad Influence                                              ",
            //"Bad Meets Evil                                             ",
            //"Before Your Love                                           ",
            //"Big Weenie                                                 ",
            //"Brain Damage                                               ",
            //"Bully                                                      ",
            //"Bump Heads                                                 ",
            //"Business                                                   ",
            //"Cleanin' Out My Closet                                     ",
            //"Come On In                                                 ",
            //"Comin' Out My Closet (parody)                              ",
            //"Crazy In Love                                              ",
            //"Criminal                                                   ",
            //"Curtains Close                                             ",
            //"Curtains Close (skit)                                      ",
            //"Curtains Up (encore Version)                               ",
            //"Dads Gone Crazy                                            ",
            //"Dance Nation — Words                                       ",
            //"Dead Wrong                                                 ",
            //"Dead Wrong (remix)                                         ",

            //"Doe Ray Me                                                 ",
            //"Drips                                                      ",
            //"Drug Ballad                                                ",
            //"Em Calls Paul (skit)                                       ",
            //"Encore                                                     ",
            //"Encore Curtains Down                                       ",
            //"Evil Deeds                                                 ",
            //"Evil Freestyle                                             ",
            //"For You Only                                               ",
            //"Forgot About Dre                                           ",
            //"Forgot About Timmy                                         ",
            //"Get U Mad                                                  ",
            //"Go To Sleep                                                ",
            //"Guilty Conscience                                          ",
            //"Hail Mary (ja Rule Diss)                                   ",
            //"Hail Mary 2003 (ja Rule Diss)                              ",
            //"Hailie's Revenge                                           ",
            //"Halie's Song                                               ",
            //"Hellbound (h&h Remix)                                      ",
            //"Hoy                                                        ",
            //"I Love You More                                            ",
            //"I'm Back                                                   ",
            //"I'm Shady                                                  ",
            //"If I Get Locked Up Tonight                                 ",
            //"If I Had                                                   ",
            //"If I Had... (radio Edit)                                   ",
            //"Infinite                                                   ",
            //"Invasion                                                   ",
            //"It's Ok                                                    ",
            //"J—rump U Make Me Sick (dopey—dying Mix)                    ",
            //"Jealousy Woes Ii                                           ",
            //"Jingle Bells                                               ",
            //"Just Lose It                                               ",
            //"Just Rhymin Wit Proof                                      ",
            //"Just Rhymin Wit' Proof (freestyle)                         ",
            //"Just The Two Of Us                                         ",
            //"Just The Two Of Us (radio Edit)                            ",
            //"Ken Kaniff (skit)                                          ",
            //"Kill You                                                   ",
            //"Kim                                                        ",
            //"Like Toy Soldiers                                          ",
            //"Loose Yourself                                             ",
            //"Lose Yourself                                              ",
            //"Lotto Vs. Rabbit                                           ",
            //"Lounge                                                     ",
            //"Love Me                                                    ",
            //"Love You More                                              ",
            //"Low, Down, Dirty                                           ",
            //"Luv Me                                                     ",
            //"Marshall Mathers                                           ",
            //"Maxine                                                     ",
            //"Mockingbird                                                ",
            //"Monkey See, Monkey Do                                      ",
            //"Mosh                                                       ",
            //"Murder Murder (remix)                                      ",
            //"Murder, Murder                                             ",
            //"My 1st Single                                              ",
            //"My Dad's Gone Crazy                                        ",
            //"My Dads Gone Craaazyy                                      ",
            //"My Fault                                                   ",
            //"My Name Is...                                              ",
            //"My Name Is... (bootleg Version)                            ",
            //"My Name Is... (radio|video Edit)                           ",
            //"My Words Are Weapons                                       ",
            //"Nail In The Coffin                                         ",
            //"Never 2 Far                                                ",
            //"Never Enough                                               ",
            //"No One's Iller Than Me                                     ",
            //"Nothing Can Change This Love                               ",
            //"Number 1 Fan                                               ",
            //"Off The Wall                                               ",
            //"One Last Time                                              ",
            //"One Shot 2 Shot                                            ",
            //"Only When I Sleep                                          ",
            //"Open Mic                                                   ",
            //"Paul (skit)                                                ",
            //"Public Service Announcement                                ",
            //"Public Service Announcement 2000                           ",
            //"Puke                                                       ",
            //"Rabbit In Parking Lot Outside The Chin Tiki                ",
            //"Rabbit Run                                                 ",
            //"Rain Man                                                   ",
            //"Rap Superstar                                              ",
            //"Remember Me                                                ",
            //"Ricky Ticky Toc                                            ",
            //"Rock Bottom                                                ",
            //"Rock City                                                  ",
            //"Role Model                                                 ",
            //"Run Rabbit Run                                             ",
            //"Say Goodbye Hollywood                                      ",
            //"Say What You Say                                           ",
            //"Searchin'                                                  ",
            //"Sing For The Moment                                        ",
            //"Soldier                                                    ",
            //"Sometimes                                                  ",
            //"Spend Some Time                                            ",
            //"Square Dance                                               ",
            //"Stan                                                       ",
            //"Steve Berman                                               ",
            //"Stimulate                                                  ",
            //"Superman                                                   ",
            //"Sweet Home Alabama                                         ",
            //"Take It Or Leave It                                        ",
            //"The Anthem                                                 ",
            //"The Beginning Of Lose Your Self                            ",
            //"The Kids                                                   ",
            //"The Kiss (skit)                                            ",
            //"The Real Slim Shady                                        ",
            //"The Roundabout                                             ",
            //"The Sauce                                                  ",
            //"The Way I Am                                               ",
            //"This Is My Time                                            ",
            //"Till I Collapse                                            ",
            //"Tonight                                                    ",
            //"Under The Influence                                        ",
            //"Unspoken Words                                             ",
            //"Wake Up Show Freestyle                                     ",
            //"We All Die One Day (with Obie Trice & G—unit)              ",
            //"We All Die Someday                                         ",
            //"We Are The Dark Clan                                       ",
            //"We As Americans                                            ",
            //"We The Realest Label                                       ",

            //"What If I Was White                                        ",
            //"What's Tha Beat                                            ",
            //"When The Music Stops                                       ",
            //"White America                                              ",
            //"Who Knew                                                   ",
            //"Without Me                                                 ",
            //"Without Me Clean Version                                   ",
            //"Without Me Dirty Version                                   ",
            //"Words Are Weapons                                          ",
            //"Yellow Brick Road                                          ",
            //"Young Souls                                                ",

            //          };

            //         eminem.CalculateSwerAndWordCount();

            //         eminem.DisplayStatistic();

            //         var nickiMinaj = new Artist("Nicki Minaj");
            //        nickiMinaj.songsTitles = new List<string>()
            //         {
            //             "Bang Bang",
            //             "Super Bass",
            //             "Good Form"
            //         };
            //         nickiMinaj.CalculateSwerAndWordCount();
            //         nickiMinaj.DisplayStatistic();

        }
    }

    
}
