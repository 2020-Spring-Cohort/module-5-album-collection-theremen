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
    class AlbumControllerTests
    {
        AlbumController testController;
        IRepository<Album> albumMockRepo;

        public AlbumControllerTests()
        {
            albumMockRepo = Substitute.For<IRepository<Album>>();
            testController = new AlbumController(albumMockRepo);
        }
    }
}
