using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.DataAccess.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
