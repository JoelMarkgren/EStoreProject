using System.ComponentModel.DataAnnotations;

namespace EStoreBlazorWASM.Models
{
    public class CellphoneViewModel
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
