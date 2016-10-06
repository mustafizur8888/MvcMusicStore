using System.Data.Entity;

namespace MvcMusicStore.Model
{
    public class MusicStoreEntites : DbContext
    {
        public MusicStoreEntites() : base("MusicStoreEntites")
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}