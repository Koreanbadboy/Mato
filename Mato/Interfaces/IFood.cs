namespace Mato.Interface
{
    public interface IFood
    {
        string Name { get; }
        int Calories { get; } // Borde mätas per 100g?
        double Protein { get; } // Mäts per 100g?
        double Carbs { get; }
        double Fat { get; }

        string GetDescription();

    }
}
