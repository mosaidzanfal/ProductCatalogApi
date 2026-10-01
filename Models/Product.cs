using System.ComponentModel.DataAnnotations;
namespace ProductCatalogApi.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        [Range(0.01,1000000.00)]
        public decimal Price { get; set; }
    }
}
