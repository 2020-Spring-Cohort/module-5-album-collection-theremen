using System;
using System.Collections.Generic;
using album_collection.Controllers;
using album_collection.Models;
using album_collection.Repositories;
using Xunit;
using NSubstitute;

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
            //List<string> artistList = new List<string>();
            //artistList

            // act

            // assert

        }
    }
}
