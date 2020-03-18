using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace album_collection.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string RecordLabel { get; set; }
        //public virtual Song Songs { get; set; }
        //public virtual string SongTitle { get; set; }


        [JsonIgnore]
        public virtual Artist Artist { get; set; }
        public virtual int ArtistId { get; set; }

        public Album()
        {
        }

        public Album(int id, string title, string image, string recordLabel)
        {
            AlbumId = id;
            Title = title;
            Image = image;
            RecordLabel = recordLabel;
            //SongTitle = songTitle;
        }
    }
}
