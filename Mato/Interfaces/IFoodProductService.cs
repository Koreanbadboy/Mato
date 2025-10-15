using Mato.Domain;

namespace Mato.Interfaces
{
    public interface IFoodProductService
    {
        Task<List<FoodProduct>> GetAllAsync();
        Task<FoodProduct?> GetByIdAsync(Guid id);
        Task AddAsync(FoodProduct product);
        Task UpdateAsync(FoodProduct product);
        Task DeleteAsync(Guid id);

    }
}
