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

            //albumList
            albumMockRepo.GetAll().Returns(expectedAlbums);

            // act
            var result = testController.Get();
            var countOfAlbums = result.Count();

            // assert
            Assert.Equal(2, countOfAlbums);
        }

        [Fact]
        public void GetById_Should_Return_Chosen_Album()
        {
            //arrange
            var id = 2;
            var firstAlbum = new Album(1, "Sigh No More", "sighnomore.jpg", "Island Records");
            var secondAlbum = new Album(2, "Test Album", "testalbum.jpg", "test");
            var expectedAlbums = new List<Album>();
            expectedAlbums.Add(firstAlbum);
            expectedAlbums.Add(secondAlbum);

            albumMockRepo.GetById(id).Returns(secondAlbum);

            //act
            var result = testController.Get(id);

            //assert
            Assert.Equal(secondAlbum, result);
        }
    }
}
