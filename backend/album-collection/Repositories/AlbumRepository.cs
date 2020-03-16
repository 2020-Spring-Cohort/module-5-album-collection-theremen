using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using album_collection.Models;

namespace album_collection.Repositories
{
    public class AlbumRepository : Repository<Album>
    {
        public AlbumRepository(AlbumCollectionContext context) : base(context)
        {

        }
    }
}
