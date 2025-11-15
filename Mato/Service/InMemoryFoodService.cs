using Mato.Domain;
using Mato.Interfaces;

namespace Mato.Service
{
    public class InMemoryFoodService : IFoodService
    {
        private readonly List<Food> _foods = new();
        public List<Food> GetAll() => _foods;

        public Food Add(Food food)
        {
            _foods.Add(food);
            return food;
        }

        public Food? GetById(Guid id)
        {
            return _foods.FirstOrDefault(f => f.Id == id);
        }
    }
}
