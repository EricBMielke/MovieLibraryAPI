using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MovieLibraryAPI.Models;

namespace MovieLibrayAPI.Controllers
{
    public class MovieController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET api/values
        [Route("movies")]
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var results = db.Movies.AsEnumerable();
            return results;
        }

        // GET api/values/5
        [Route("movies/Movie/{MovieId}")]
        [HttpGet]
        public Movie Get(int MovieId)
        {
            Movie movie = db.Movies.Where(m => m.MovieId == MovieId).FirstOrDefault();
            return movie;
        }

        // POST api/values
        public void Post([FromBody]Movie value)
        {
            // Create movie in db logic
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            // Update movie in db logic
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            // Delete movie from db logic
        }
    }

}