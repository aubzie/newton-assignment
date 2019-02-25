namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_many_to_many_for_videoGames_and_genres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Genres", "VideoGame_Id", "dbo.VideoGames");
            DropIndex("dbo.Genres", new[] { "VideoGame_Id" });
            CreateTable(
                "dbo.VideoGameGenres",
                c => new
                    {
                        VideoGame_Id = c.Int(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.VideoGame_Id, t.Genre_Id })
                .ForeignKey("dbo.VideoGames", t => t.VideoGame_Id, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.VideoGame_Id)
                .Index(t => t.Genre_Id);
            
            DropColumn("dbo.Genres", "VideoGame_Id");
            DropColumn("dbo.VideoGames", "ImageURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VideoGames", "ImageURL", c => c.String());
            AddColumn("dbo.Genres", "VideoGame_Id", c => c.Int());
            DropForeignKey("dbo.VideoGameGenres", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.VideoGameGenres", "VideoGame_Id", "dbo.VideoGames");
            DropIndex("dbo.VideoGameGenres", new[] { "Genre_Id" });
            DropIndex("dbo.VideoGameGenres", new[] { "VideoGame_Id" });
            DropTable("dbo.VideoGameGenres");
            CreateIndex("dbo.Genres", "VideoGame_Id");
            AddForeignKey("dbo.Genres", "VideoGame_Id", "dbo.VideoGames", "Id");
        }
    }
}
