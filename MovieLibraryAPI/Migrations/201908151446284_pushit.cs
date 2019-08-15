namespace MovieLibraryAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pushit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "PictureURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "PictureURL");
        }
    }
}
