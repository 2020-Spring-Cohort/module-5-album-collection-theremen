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
    }
}
