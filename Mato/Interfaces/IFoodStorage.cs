namespace Mato.Interfaces
{
    public interface IFoodStorage
    {
        Task<List<FoodProduct>>LoadAsync();
        Task SaveAsync(List<FoodProduct> products);
    }
}
