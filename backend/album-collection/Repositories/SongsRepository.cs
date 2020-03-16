using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using album_collection.Models;

namespace album_collection.Repositories
{
    public class SongsRepository : Repository<Songs>
    {
        public SongsRepository(AlbumCollectionContext context) : base(context)
        {

        }
    }
}
