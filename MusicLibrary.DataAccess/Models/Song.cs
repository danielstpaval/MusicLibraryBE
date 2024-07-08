namespace MusicLibrary.DataAccess.Models
{
    public class Song : BaseModel
    {
        public string Title { get; set; }

        public decimal Length { get; set; }

        public Album Album{ get; set; }

        public string AlbumId { get; set; }
    }
}
