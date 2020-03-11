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
        public string Songs { get; set; }
        public string RecordLabel { get; set; }

        public Album()
        {
        }

        public Album(string title, string image, string songs, string recordLabel)
        {
            Title = title;
            Image = image;
            Songs = songs;
            RecordLabel = recordLabel;

        }
    }

    
}
