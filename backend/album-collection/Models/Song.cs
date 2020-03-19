using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace album_collection.Models
{
    public class Song
    {
        public int SongId {get; set;}
        public string SongTitle { get; set; }
        public string Links { get; set; }
        public string Duration { get; set; }

        [JsonIgnore]
        public virtual Album Album { get; set; }
        public virtual int AlbumId { get; set; }

        public Song()
        {
        }

        public Song(int id, string songTitle, string links, string duration)
        {
            SongId = id;
            SongTitle = songTitle;
            Links = links;
            Duration = duration;
        }
    }
}
