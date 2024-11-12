using System.ComponentModel.DataAnnotations;

namespace EStoreAPI.Models
{
    public class Cellphone
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Model { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string? Color { get; set; }
        public string? Image { get; set; }

    }
}
