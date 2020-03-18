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
                    ArtistId = 1
                },
                new Album
                {
                    AlbumId = 2,
                    Title = "Babel",
                    Image = "babel.jpg",
                    RecordLabel = "Island Records",
                    ArtistId = 1
                },
                new Album
                {
                    AlbumId = 3,
                    Title = "Unleashed Memories",
                    Image = "unleashedmemories.jpg",
                    RecordLabel = "Century Media",
                    ArtistId = 2
                },
                new Album
                {
                    AlbumId = 4,
                    Title = "Comalies",
                    Image = "comalies.jpg",
                    RecordLabel = "Century Media",
                    ArtistId = 2
                }
            );
            modelBuilder.Entity<Song>().HasData(
                // Mumford & Sons - Sigh No More
                new Song
                {
                    SongId = 1,
                    SongTitle = "Sigh No More",
                    Links = "link.html",
                    Duration = "3:30",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 2,
                    SongTitle = "The Cave",
                    Links = "link.html",
                    Duration = "3:37",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 3,
                    SongTitle = "Winter Winds",
                    Links = "link.html",
                    Duration = "3:39",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 4,
                    SongTitle = "Roll Away Your Stone",
                    Links = "link.html",
                    Duration = "4:23",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 5,
                    SongTitle = "White Blank Page",
                    Links = "link.html",
                    Duration = "4:14",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 6,
                    SongTitle = "I Gave You All",
                    Links = "link.html",
                    Duration = "4:18",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 7,
                    SongTitle = "Little Lion Man",
                    Links = "link.html",
                    Duration = "4:05",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 8,
                    SongTitle = "Timshel",
                    Links = "link.html",
                    Duration = "2:54",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 9,
                    SongTitle = "Thistle & Weeds",
                    Links = "link.html",
                    Duration = "4:50",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 10,
                    SongTitle = "Awake My Soul",
                    Links = "link.html",
                    Duration = "4:13",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 11,
                    SongTitle = "Dust Bowl Dance",
                    Links = "link.html",
                    Duration = "4:40",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 12,
                    SongTitle = "After the Storm",
                    Links = "link.html",
                    Duration = "4:11",
                    AlbumId = 1
                },

                // Mumford & Sons - Babel
                new Song
                {
                    SongId = 13,
                    SongTitle = "Babel",
                    Links = "link.html",
                    Duration = "3:29",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 14,
                    SongTitle = "Whispers in the Dark",
                    Links = "link.html",
                    Duration = "3:16",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 15,
                    SongTitle = "I Will Wait",
                    Links = "link.html",
                    Duration = "4:37",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 16,
                    SongTitle = "Holland Road",
                    Links = "link.html",
                    Duration = "4:13",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 17,
                    SongTitle = "Ghosts That We Knew",
                    Links = "link.html",
                    Duration = "5:40",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 18,
                    SongTitle = "Lover of the Light",
                    Links = "link.html",
                    Duration = "5:15",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 19,
                    SongTitle = "Lovers' Eyes",
                    Links = "link.html",
                    Duration = "5:21",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 20,
                    SongTitle = "Reminder",
                    Links = "link.html",
                    Duration = "2:05",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 21,
                    SongTitle = "Hopeless Wanderer",
                    Links = "link.html",
                    Duration = "5:08",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 22,
                    SongTitle = "Broken Crown",
                    Links = "link.html",
                    Duration = "4:16",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 23,
                    SongTitle = "Below My Feet",
                    Links = "link.html",
                    Duration = "4:52",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 24,
                    SongTitle = "Not With Haste",
                    Links = "link.html",
                    Duration = "4:09",
                    AlbumId = 2
                },

                // Lacuna Coil - Unleashed Memories
                new Song
                {
                    SongId = 25,
                    SongTitle = "Heir of a Dying Day",
                    Links = "link.html",
                    Duration = "4:59",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 26,
                    SongTitle = "To Live Is to Hide",
                    Links = "link.html",
                    Duration = "4:34",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 27,
                    SongTitle = "Purify",
                    Links = "link.html",
                    Duration = "4:36",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 28,
                    SongTitle = "Senzafine",
                    Links = "link.html",
                    Duration = "3:53",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 29,
                    SongTitle = "When a Dead Man Walks",
                    Links = "link.html",
                    Duration = "5:54",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 30,
                    SongTitle = "1:19",
                    Links = "link.html",
                    Duration = "4:58",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 31,
                    SongTitle = "Cold Heritage",
                    Links = "link.html",
                    Duration = "5:23",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 32,
                    SongTitle = "Distant Sun",
                    Links = "link.html",
                    Duration = "5:29",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 33,
                    SongTitle = "A Current Obsession",
                    Links = "link.html",
                    Duration = "5:20",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 34,
                    SongTitle = "Wave of Anguish",
                    Links = "link.html",
                    Duration = "4:40",
                    AlbumId = 3
                },

                // Lacuna Coil - Comalies
                new Song
                {
                    SongId = 35,
                    SongTitle = "Swamped",
                    Links = "link.html",
                    Duration = "4:00",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 36,
                    SongTitle = "Heaven's Lie",
                    Links = "link.html",
                    Duration = "4:46",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 37,
                    SongTitle = "Daylight Dancer",
                    Links = "link.html",
                    Duration = "3:50",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 38,
                    SongTitle = "Humane",
                    Links = "link.html",
                    Duration = "4:12",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 39,
                    SongTitle = "Self Deception",
                    Links = "link.html",
                    Duration = "3:31",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 40,
                    SongTitle = "Aeon",
                    Links = "link.html",
                    Duration = "1:56",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 41,
                    SongTitle = "Tight Rope",
                    Links = "link.html",
                    Duration = "4:15",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 42,
                    SongTitle = "The Ghost Woman and the Hunter",
                    Links = "link.html",
                    Duration = "4:09",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 43,
                    SongTitle = "Unspoken",
                    Links = "link.html",
                    Duration = "3:37",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 44,
                    SongTitle = "Entwined",
                    Links = "link.html",
                    Duration = "3:59",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 45,
                    SongTitle = "The Prophet Said",
                    Links = "link.html",
                    Duration = "4:32",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 46,
                    SongTitle = "Angel's Punishment",
                    Links = "link.html",
                    Duration = "3:56",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 47,
                    SongTitle = "Comalies",
                    Links = "link.html",
                    Duration = "5:01",
                    AlbumId = 4
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
