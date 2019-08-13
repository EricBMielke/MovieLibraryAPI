namespace MovieLibraryAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class push3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                        Title = c.String(),
                        DirectorName = c.String(),
                    })
                .PrimaryKey(t => t.MovieId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
