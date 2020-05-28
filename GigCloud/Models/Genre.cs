using System.ComponentModel.DataAnnotations;

namespace GigCloud.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}