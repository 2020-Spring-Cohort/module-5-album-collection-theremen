using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace album_collection.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Albums { get; set; }
        public string Hometown { get; set; }

        public Artist()
        {
        }

        public Artist(string name, string image, string albums, string hometown)
        {
            Name = name;
            Image = image;
            Albums = albums;
            Hometown = hometown;

        }
    }
}
