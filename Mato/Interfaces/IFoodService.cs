using Mato.Domain;

namespace Mato.Interfaces
{
    public interface IFoodService
    {
        List<Food> GetAll();
        Food Add(Food food);
        Food? GetById(Guid id);
    }
}
