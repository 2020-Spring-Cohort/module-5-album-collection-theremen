using System;
using System.Collections.Generic;
using album_collection.Controllers;
using album_collection.Models;
using album_collection.Repositories;
using Xunit;
using NSubstitute;
using System.Linq;

namespace album_collection.Tests
{
    public class SongControllerTests
    {
        SongController testController;
        IRepository<Song> songMockRepo;

        public SongControllerTests()
        {
            songMockRepo = Substitute.For<IRepository<Song>>();
            testController = new SongController(songMockRepo);
        }

        [Fact]
        public void Get_Returns_Count_Of_Songs()
        {
            // arrange
            var expectedArtists = new List<Song>()
            {
              new Song(1, "Sigh No More", "link.html", "3:30"),
              new Song(2, "Test Song", "testlink.html", "test")
            };

            //songList
            songMockRepo.GetAll().Returns(expectedSongs);

            // act
            var result = testController.Get();
            var countOfArtists = result.Count();

            // assert
            Assert.Equal(2, countOfArtists);
        }
    }
}
