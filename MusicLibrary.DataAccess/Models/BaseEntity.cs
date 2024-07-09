using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.DataAccess.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
