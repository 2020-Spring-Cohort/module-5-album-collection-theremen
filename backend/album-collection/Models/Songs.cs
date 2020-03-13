using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Songs
    {
        public int SongId {get; set;}
        public string SongTitle { get; set; }
        public string Links { get; set; }
        public string Duration { get; set; }

        public Songs()
        {
        }

        public Songs(string songTitle, string links, string duration)
        {
            SongTitle = songTitle;
            Links = links;
            Duration = duration;
        }
    }
}
