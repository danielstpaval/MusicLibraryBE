namespace MusicLibrary.DataAccess.Models
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }

        public List<Album> Albums { get; set; }
    }
}
