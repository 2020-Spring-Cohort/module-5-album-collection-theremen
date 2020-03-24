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

        [Fact]
        public void Post_Creates_New_Artist()
        {
            // arrange
            var newArtist = new Artist(1, "Mumford & Sons", "mumfordandsons.jpg", "London");
            var artistList = new List<Artist>();

            // Use When..Do to substitute for methods that don't return a value, like the Repository method Create()
            // When() allows us to call the method on the substitute and pass an argument
            // Do() allows us to pass a callback function that executes when the method is called
            artistMockRepo.When(t => t.Create(newArtist))
                .Do(t => artistList.Add(newArtist));

            artistMockRepo.GetAll().Returns(artistList);

            // act
            var result = testController.Post(newArtist);

            // assert
            Assert.Contains(newArtist, result);
        }
    }
}
