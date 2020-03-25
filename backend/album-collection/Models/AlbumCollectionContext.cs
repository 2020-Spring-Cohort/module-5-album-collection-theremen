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
                    Image = "lacuna_band.jpg",
                    Hometown = "Milan, Italy",
                }
            );
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    AlbumId = 1,
                    Title = "Sigh No More",
                    Image = "Mumfordsonssighnomore.jpg",
                    RecordLabel = "Island Records",
                    ArtistId = 1
                },
                new Album
                {
                    AlbumId = 2,
                    Title = "Babel",
                    Image = "Babelcoverart.jpg",
                    RecordLabel = "Island Records",
                    ArtistId = 1
                },
                new Album
                {
                    AlbumId = 3,
                    Title = "Unleashed Memories",
                    Image = "lacuna_unleashed_album.jpg",
                    RecordLabel = "Century Media",
                    ArtistId = 2
                },
                new Album
                {
                    AlbumId = 4,
                    Title = "Comalies",
                    Image = "lacuna_coma_album.jpg",
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
                    Links = "https://www.youtube.com/watch?v=4WJyAYhCt1s",
                    Duration = "3:30",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 2,
                    SongTitle = "The Cave",
                    Links = "https://www.youtube.com/watch?v=fNy8llTLvuA",
                    Duration = "3:37",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 3,
                    SongTitle = "Winter Winds",
                    Links = "https://www.youtube.com/watch?v=_KCg_QEHtkY",
                    Duration = "3:39",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 4,
                    SongTitle = "Roll Away Your Stone",
                    Links = "https://www.youtube.com/watch?v=TFUoyz5l4aM",
                    Duration = "4:23",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 5,
                    SongTitle = "White Blank Page",
                    Links = "https://www.youtube.com/watch?v=ZTqgeUkPO0A",
                    Duration = "4:14",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 6,
                    SongTitle = "I Gave You All",
                    Links = "https://www.youtube.com/watch?v=4NouN_IxvM8",
                    Duration = "4:18",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 7,
                    SongTitle = "Little Lion Man",
                    Links = "https://www.youtube.com/watch?v=am3WKqVX6D8",
                    Duration = "4:05",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 8,
                    SongTitle = "Timshel",
                    Links = "https://www.youtube.com/watch?v=pSPy59xNtTU",
                    Duration = "2:54",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 9,
                    SongTitle = "Thistle & Weeds",
                    Links = "https://www.youtube.com/watch?v=pxScXFVZHH8",
                    Duration = "4:50",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 10,
                    SongTitle = "Awake My Soul",
                    Links = "https://www.youtube.com/watch?v=DFQVtIiRDuA",
                    Duration = "4:13",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 11,
                    SongTitle = "Dust Bowl Dance",
                    Links = "https://www.youtube.com/watch?v=sPSYuxVyf7E",
                    Duration = "4:40",
                    AlbumId = 1
                },
                new Song
                {
                    SongId = 12,
                    SongTitle = "After the Storm",
                    Links = "https://www.youtube.com/watch?v=3jNILCzQurM",
                    Duration = "4:11",
                    AlbumId = 1
                },

                // Mumford & Sons - Babel
                new Song
                {
                    SongId = 13,
                    SongTitle = "Babel",
                    Links = "https://www.youtube.com/watch?v=iWza_On7ajs",
                    Duration = "3:29",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 14,
                    SongTitle = "Whispers in the Dark",
                    Links = "https://www.youtube.com/watch?v=zNaM-N1NdGo",
                    Duration = "3:16",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 15,
                    SongTitle = "I Will Wait",
                    Links = "https://www.youtube.com/watch?v=rGKfrgqWcv0",
                    Duration = "4:37",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 16,
                    SongTitle = "Holland Road",
                    Links = "https://www.youtube.com/watch?v=Yemeb524Kx4",
                    Duration = "4:13",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 17,
                    SongTitle = "Ghosts That We Knew",
                    Links = "https://www.youtube.com/watch?v=FM6EzfZQWEI",
                    Duration = "5:40",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 18,
                    SongTitle = "Lover of the Light",
                    Links = "https://www.youtube.com/watch?v=lR5GXgC2q2M",
                    Duration = "5:15",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 19,
                    SongTitle = "Lovers' Eyes",
                    Links = "https://www.youtube.com/watch?v=9yw2_HSj87s",
                    Duration = "5:21",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 20,
                    SongTitle = "Reminder",
                    Links = "https://www.youtube.com/watch?v=8KV98HB8o7o",
                    Duration = "2:05",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 21,
                    SongTitle = "Hopeless Wanderer",
                    Links = "https://www.youtube.com/watch?v=zushTvKC0PU",
                    Duration = "5:08",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 22,
                    SongTitle = "Broken Crown",
                    Links = "https://www.youtube.com/watch?v=mjqUXexR8Vo",
                    Duration = "4:16",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 23,
                    SongTitle = "Below My Feet",
                    Links = "https://www.youtube.com/watch?v=3Imwnc8Ad9M",
                    Duration = "4:52",
                    AlbumId = 2
                },
                new Song
                {
                    SongId = 24,
                    SongTitle = "Not With Haste",
                    Links = "https://www.youtube.com/watch?v=avT0Rj50130",
                    Duration = "4:09",
                    AlbumId = 2
                },

                // Lacuna Coil - Unleashed Memories
                new Song
                {
                    SongId = 25,
                    SongTitle = "Heir of a Dying Day",
                    Links = "https://www.youtube.com/watch?v=sCXkbBBG4f0",
                    Duration = "4:59",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 26,
                    SongTitle = "To Live Is to Hide",
                    Links = "https://www.youtube.com/watch?v=wD20Oze5NYw",
                    Duration = "4:34",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 27,
                    SongTitle = "Purify",
                    Links = "https://www.youtube.com/watch?v=tFfchptAI3w",
                    Duration = "4:36",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 28,
                    SongTitle = "Senzafine",
                    Links = "https://www.youtube.com/watch?v=zDi1FwihzlQ",
                    Duration = "3:53",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 29,
                    SongTitle = "When a Dead Man Walks",
                    Links = "https://www.youtube.com/watch?v=jFfEfpbH40E",
                    Duration = "5:54",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 30,
                    SongTitle = "1:19",
                    Links = "https://www.youtube.com/watch?v=8lfcPeHM73M",
                    Duration = "4:58",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 31,
                    SongTitle = "Cold Heritage",
                    Links = "https://www.youtube.com/watch?v=7oIjVK08_8Y",
                    Duration = "5:23",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 32,
                    SongTitle = "Distant Sun",
                    Links = "https://www.youtube.com/watch?v=lTyiPm4lJBc",
                    Duration = "5:29",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 33,
                    SongTitle = "A Current Obsession",
                    Links = "https://www.youtube.com/watch?v=2aQDWfnOLlE",
                    Duration = "5:20",
                    AlbumId = 3
                },
                new Song
                {
                    SongId = 34,
                    SongTitle = "Wave of Anguish",
                    Links = "https://www.youtube.com/watch?v=f_2EhXHf4bs",
                    Duration = "4:40",
                    AlbumId = 3
                },

                // Lacuna Coil - Comalies
                new Song
                {
                    SongId = 35,
                    SongTitle = "Swamped",
                    Links = "https://www.youtube.com/watch?v=nOuxOUYycoU",
                    Duration = "4:00",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 36,
                    SongTitle = "Heaven's a Lie",
                    Links = "https://www.youtube.com/watch?v=4wfRHPsRGkk",
                    Duration = "4:46",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 37,
                    SongTitle = "Daylight Dancer",
                    Links = "https://www.youtube.com/watch?v=EPo-0hJhOPo",
                    Duration = "3:50",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 38,
                    SongTitle = "Humane",
                    Links = "https://www.youtube.com/watch?v=IOvSNweknM0",
                    Duration = "4:12",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 39,
                    SongTitle = "Self Deception",
                    Links = "https://www.youtube.com/watch?v=UDcMYJU_K7E",
                    Duration = "3:31",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 40,
                    SongTitle = "Aeon",
                    Links = "https://www.youtube.com/watch?v=rpS0vVzPPLw",
                    Duration = "1:56",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 41,
                    SongTitle = "Tight Rope",
                    Links = "https://www.youtube.com/watch?v=mR-B5cjToL0",
                    Duration = "4:15",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 42,
                    SongTitle = "The Ghost Woman and the Hunter",
                    Links = "https://www.youtube.com/watch?v=Nw561NWK9Zg",
                    Duration = "4:09",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 43,
                    SongTitle = "Unspoken",
                    Links = "https://www.youtube.com/watch?v=3ixjeXLCAiA",
                    Duration = "3:37",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 44,
                    SongTitle = "Entwined",
                    Links = "https://www.youtube.com/watch?v=Nn2WzHcyn5I",
                    Duration = "3:59",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 45,
                    SongTitle = "The Prophet Said",
                    Links = "https://www.youtube.com/watch?v=YSXvlOPLk3c",
                    Duration = "4:32",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 46,
                    SongTitle = "Angel's Punishment",
                    Links = "https://www.youtube.com/watch?v=vCIJrEtjXfw",
                    Duration = "3:56",
                    AlbumId = 4
                },
                new Song
                {
                    SongId = 47,
                    SongTitle = "Comalies",
                    Links = "https://www.youtube.com/watch?v=SzN1bHSkpQI",
                    Duration = "5:01",
                    AlbumId = 4
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
