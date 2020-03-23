using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using album_collection.Repositories;
using album_collection.Models;

namespace album_collection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {

        IRepository<Song> songRepo;
        
        public SongController(IRepository<Song> songRepo)
        {
            this.songRepo = songRepo;
        }

        // GET: api/Song
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songRepo.GetAll();
        }


        // GET: api/Song/5
        [HttpGet("{id}")]
        public Song Get(int id)
        {
            return songRepo.GetById(id);
        }


        // POST: api/Song
        [HttpPost]
        public IEnumerable<Song> Post([FromBody] Song value)
        {
            songRepo.Create(value);
            return songRepo.GetAll();
        }


        // PUT: api/Song/5

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Song> Delete(int id)
        {
            var song = songRepo.GetById(id);
            songRepo.Delete(song);
            return songRepo.GetAll();
        }
    }
}
