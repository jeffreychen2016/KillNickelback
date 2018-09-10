using System;
using System.Collections.Generic;

namespace KillNickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Song> AllSongs = new HashSet<Song>();
            List<Song> GoodSongs = new List<Song>();


            for (var i = 0; i < 6; i++)
            {
                AllSongs.Add(new Song("Other Artists", ", Good Song-" + i));
            }

            AllSongs.Add(new Song("Nickelback", "Song-7"));

            foreach (var Song in AllSongs)
            {
                if (Song.Artist != "Nickelback")
                {
                    GoodSongs.Add(Song);
                }
            }

            foreach (var Song in GoodSongs)
            {
                Console.WriteLine(Song.Artist + " " + Song.Name);
            }

        }
    }
}
