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
    public class ArtistControllerTests
    {
        ArtistController testController;
        IRepository<Artist> artistMockRepo;

        public ArtistControllerTests()
        {
            artistMockRepo = Substitute.For<IRepository<Artist>>();
            testController = new ArtistController(artistMockRepo);
        }
        [Fact]
        public void Get_Returns_Count_Of_Artists()
        {
            // arrange
            var expectedArtists = new List<Artist>()
            {
              new Artist(1, "Mumford & Sons", "mumfordandsons.jpg", "London"),
              new Artist(2, "Test Artist", "testartist.jpg", "test")
            };
            //artistList
            artistMockRepo.GetAll().Returns(expectedArtists);
            // act
            var result = testController.Get();
            var countOfArtists = result.Count();

            // assert
            Assert.Equal(2, countOfArtists);

        }
    }
}
