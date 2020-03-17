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
        //private ModelBuilder modelBuilder;
        
        public AlbumCollectionContext(DbContextOptions<AlbumCollectionContext> options) : base(options)
        {
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=album_collection;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    Name = "Mumford & Sons",
                    Image = "mumfordsons.jpg",
                    Hometown = "London, UK",
                },
                new Artist
                {
                    ArtistId = 2,
                    Name = "Lacuna Coil",
                    Image = "lacunacoil.jpg",
                    Hometown = "Milan, Italy",
                }
            );
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    AlbumId = 1,
                    Title = "Sigh No More",
                    Image = "sighnomore.jpg",
                    RecordLabel = "Island Records",
                },
                new Album
                {
                    AlbumId = 2,
                    Title = "Babel",
                    Image = "babel.jpg",
                    RecordLabel = "Island Records",
                },
                new Album
                {
                    AlbumId = 3,
                    Title = "Unleashed Memories",
                    Image = "unleashedmemories.jpg",
                    RecordLabel = "Century Media",
                },
                new Album
                {
                    AlbumId = 4,
                    Title = "Comalies",
                    Image = "comalies.jpg",
                    RecordLabel = "Century Media",
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
