namespace MusicLibrary.DataAccess.Models
{
    public class Song : BaseEntity
    {
        public string Title { get; set; }

        public string Length { get; set; }

        public Album Album{ get; set; }

        public int AlbumId { get; set; }
    }
}
