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
        // GET movies
        [Route("movies")]
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            var results = db.Movies.AsEnumerable();
            return results;
        }

        // GET movies/movie/5
        [Route("movies/movie/{MovieId}")]
        [HttpGet]
        public Movie Get(int MovieId)
        {
            Movie movie = db.Movies.Where(m => m.MovieId == MovieId).FirstOrDefault();
            return movie;
        }

        // POST movies
        [Route("movies")]
        [HttpPost]
        public void Post([FromBody]Movie value)
        {
            db.Movies.Add(new Movie()
            {
                MovieId = value.MovieId,
                Title = value.Title,
                Genre = value.Genre,
                DirectorName = value.DirectorName
            }) ; 

            db.SaveChanges();
        }

      
        // PUT movies
        [HttpPut]
        [Route("movies/movie/{id}")]
        public void Put(int id, [FromBody]Movie value)
        {
            Movie movie = db.Movies.Where(m => m.MovieId == id).FirstOrDefault();

            movie.MovieId = value.MovieId;
            movie.Title = value.Title;
            movie.Genre = value.Genre;
            movie.DirectorName = value.DirectorName;

            db.SaveChanges();
        }

        // DELETE movies/5
        [Route("movies/movie/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            Movie movieDelete = db.Movies.Where(s => s.MovieId == id).FirstOrDefault(); 
            db.Movies.Remove(movieDelete);
            db.SaveChanges();
        }
    }

}