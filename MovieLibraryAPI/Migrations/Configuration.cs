namespace MovieLibraryAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieLibraryAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieLibraryAPI.Models.ApplicationDbContext context)
        {
            //Seed Data
            //context.Movies.AddOrUpdate(
            //   new Models.Movie { Title = "The Departed", Genre = "Drama", DirectorName = "Martin Scorsese" , PictureURL = "https://resizing.flixster.com/WT_ZNx5qQ9N08xHyJkU8jqDpZ-Q=/206x305/v1.bTsxMTE2NjcyMTtqOzE4MjE5OzEyMDA7ODAwOzEyMDA"},
            //   new Models.Movie { Title = "The Dark Knight", Genre = "Drama", DirectorName = "Christopher Nolan" , PictureURL = "http://www.gstatic.com/tv/thumb/v22vodart/173378/p173378_v_v8_at.jpg" },
            //   new Models.Movie { Title = "Inception", Genre = "Drama", DirectorName = "Christopher Nolan" , PictureURL = "https://is3-ssl.mzstatic.com/image/thumb/Video18/v4/5f/81/8f/5f818f27-3fdd-3a94-e7ff-0fa0748af261/pr_source.lsr/268x0w.png" },
            //   new Models.Movie { Title = "Pineapple Express", Genre = "Comedy", DirectorName = "David Gordon Green" , PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/c/ca/Pineapple_Express_Poster.jpg/220px-Pineapple_Express_Poster.jpg" },
            //    new Models.Movie { Title = "Die Hard", Genre = "Action", DirectorName = "John McTiernan" , PictureURL = "http://barkerhost.com/wp-content/uploads/sites/4/2015/12/die-hard.jpg"}
            //);
        }
    }
}
