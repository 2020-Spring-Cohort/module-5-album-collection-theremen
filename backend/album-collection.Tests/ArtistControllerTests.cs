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

        [Fact]

        public void GetById_Should_Return_Chosen_Artist()
        {
            //arrange
            var id = 2;
            var firstArtist = new Artist(1, "Mumford & Sons", "mumfordandsons.jpg", "London");
            var secondArtist = new Artist(2, "Test Artist", "testartist.jpg", "test");
            var expectedArtists = new List<Artist>();
            expectedArtists.Add(firstArtist);
            expectedArtists.Add(secondArtist);

            artistMockRepo.GetById(id).Returns(secondArtist);
            //act

            var result = testController.Get(id);

            //assert

            Assert.Equal(secondArtist, result);

        }
    }
}
