using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;

namespace MvcMusicStore.Model
{
    [Table("Genre")]
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }

    }

    [Table("Album")]
    public class Album
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }

        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }

        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
    [Table("Artist")]

    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}
