namespace MusicLibrary.DataAccess.Models
{
    public class Album : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public Artist Artist { get; set; }

        public string ArtistId { get; set; }
    }
}
