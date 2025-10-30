using Mato.Interface;

namespace Mato.Domain
{
    public class Ingredient
    {
        public IFood Food { get; set; } = null!;
        public double Quantity { get; set; }
        public string Unit { get; set; } = "g"; // eller "ml", "st" etc.
    }

}
