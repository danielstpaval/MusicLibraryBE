namespace MusicLibrary.DataAccess.Models
{
    public class Album : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Artist Artist { get; set; }

        public int ArtistId { get; set; }

        public List<Song> Songs { get; set; }
    }
}
