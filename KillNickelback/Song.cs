using System.Collections.Generic;

namespace KillNickelback
{
    class Song
    {
        public string Artist { get; set; }
        public string Name { get; set; }

        public Song(string Artist, string Name)
        {
            this.Artist = Artist;
            this.Name = Name;
        }
    }
}
