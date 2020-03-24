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
    public class AlbumControllerTests
    {
        AlbumController testController;
        IRepository<Album> albumMockRepo;

        public AlbumControllerTests()
        {
            albumMockRepo = Substitute.For<IRepository<Album>>();
            testController = new AlbumController(albumMockRepo);
        }

        [Fact]
        public void Get_Returns_Count_Of_Albums()
        {
            // arrange
            var expectedAlbums = new List<Album>()
            {
              new Album(1, "Sigh No More", "sighnomore.jpg", "Island Records"),
              new Album(2, "Test Album", "testalbum.jpg", "test")
            };

            //artistList
            albumMockRepo.GetAll().Returns(expectedAlbums);

            // act
            var result = testController.Get();
            var countOfAlbums = result.Count();

            // assert
            Assert.Equal(2, countOfAlbums);
        }
    }
}
