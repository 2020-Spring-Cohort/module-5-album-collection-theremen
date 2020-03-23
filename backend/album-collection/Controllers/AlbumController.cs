using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using album_collection.Models;
using album_collection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace album_collection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        IRepository<Album> albumRepo;

        public AlbumController(IRepository<Album> albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        // GET: api/Album
        [HttpGet]
        public IEnumerable<Album> Get()
        {
            return albumRepo.GetAll();
        }

        // GET: api/Album/5
        [HttpGet("{id}")]
        public Album Get(int id)
        {
            return albumRepo.GetById(id);
        }

        // POST: api/Album
        [HttpPost]
        public IEnumerable<Album> Post([FromBody] Album value)
        {
            albumRepo.Create(value);
            return albumRepo.GetAll();
        }

        // PUT: api/Album/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Album> Delete(int id)
        {
            var album = albumRepo.GetById(id);
            albumRepo.Delete(album);
            return albumRepo.GetAll();
        }
    }
}
