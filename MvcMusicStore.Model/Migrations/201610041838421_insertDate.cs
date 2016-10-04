namespace MvcMusicStore.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertDate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Albums", newName: "Album");
            RenameTable(name: "dbo.Artists", newName: "Artist");
            RenameTable(name: "dbo.Genres", newName: "Genre");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Genre", newName: "Genres");
            RenameTable(name: "dbo.Artist", newName: "Artists");
            RenameTable(name: "dbo.Album", newName: "Albums");
        }
    }
}
