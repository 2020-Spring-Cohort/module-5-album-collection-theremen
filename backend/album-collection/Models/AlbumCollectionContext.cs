using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace album_collection.Models
{
    public class AlbumCollectionContext : DbContext
    {
        public AlbumCollectionContext(DbContextOptions<AlbumCollectionContext> options) : base(options)
        {
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Songs> Songs { get; set; }
    }
}
