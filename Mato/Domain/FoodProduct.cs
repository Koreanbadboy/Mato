using System.ComponentModel.DataAnnotations;

namespace Mato.Domain
{
    public class FoodProduct
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Unit { get; set; } = string.Empty; // t.ex. "kg", "g", "l"
        public bool IsOrganic { get; set; }
    }
}
