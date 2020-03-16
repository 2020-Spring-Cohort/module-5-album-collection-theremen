using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using album_collection.Models;


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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=album_collection;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
    }
    
}
