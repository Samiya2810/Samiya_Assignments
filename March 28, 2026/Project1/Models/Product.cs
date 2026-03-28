using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(0.01, 10000)]
        public decimal Price { get; set; }

        public string? Category { get; set; }
    }
}

