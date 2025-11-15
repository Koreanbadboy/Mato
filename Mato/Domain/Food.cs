using Mato.Interface;
using System.Xml.Linq;

namespace Mato.Domain
{
    public class Food : IFood
    {
        public Guid Id{ get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fat { get; set; }

        public string Category { get; set; } = string.Empty;
        public bool IsVegan { get; set; }
        public bool IsGlutenFree { get; set; }

        public string GetDescription()
        {
            return $"{Name} ({Calories} kcal/100g)";
        }

    }

}







