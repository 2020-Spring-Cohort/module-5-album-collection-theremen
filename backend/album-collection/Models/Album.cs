using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace album_collection.Models
{
    public class Album
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string RecordLabel { get; set; }

        public virtual Songs Songs { get; set; }
        public virtual string SongTitle { get; set; }


        public Album()
        {
        }

        public Album(string title, string image, string recordLabel, string songTitle)
        {
            Title = title;
            Image = image;
            RecordLabel = recordLabel;
            SongTitle = songTitle;
        }
    }

    
}
