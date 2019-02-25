namespace API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        VideoGame_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VideoGames", t => t.VideoGame_Id)
                .Index(t => t.VideoGame_Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VideoGames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Year = c.Int(),
                        ImageURL = c.String(),
                        PublisherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.PublisherId, cascadeDelete: true)
                .Index(t => t.PublisherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoGames", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Genres", "VideoGame_Id", "dbo.VideoGames");
            DropIndex("dbo.VideoGames", new[] { "PublisherId" });
            DropIndex("dbo.Genres", new[] { "VideoGame_Id" });
            DropTable("dbo.VideoGames");
            DropTable("dbo.Publishers");
            DropTable("dbo.Genres");
        }
    }
}
