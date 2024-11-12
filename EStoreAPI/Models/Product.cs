using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EStoreAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        [JsonIgnore]
        public ProductCategory Category { get; set; }
        [ForeignKey("ProductCategory")]
        public int CategoryId { get; set; }
    }
}
