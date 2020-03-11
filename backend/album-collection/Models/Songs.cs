using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Songs
    {
        public string Title { get; set; }
        public string Links { get; set; }
        public string Duration { get; set; }

        public Songs()
        {
        }

        public Songs(string title, string links, string duration)
        {
            Title = title;
            Links = links;
            Duration = duration;

        }
    }
}
