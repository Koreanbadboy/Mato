namespace Mato.Services
{
    public class FoodProductService : IFoodProductService
    {
        private readonly IFoodStorage _storage;

        public FoodProductService(IFoodStorage storage)
        {
            _storage = storage;
        }

        public async Task<List<FoodProduct>> GetAllAsync() => await _storage.LoadAsync();

        public async Task AddAsync(FoodProduct product)
        {
            var products = await _storage.LoadAsync();
            products.Add(product);
            await _storage.SaveAsync(products);
        }

        public async Task UpdateAsync(FoodProduct product)
        {
            var products = await _storage.LoadAsync();
            var index = products.FindIndex(p => p.Id == product.Id);
            if (index >= 0) products[index] = product;
            await _storage.SaveAsync(products);
        }

        public async Task DeleteAsync(Guid id)
        {
            var products = await _storage.LoadAsync();
            products.RemoveAll(p => p.Id == id);
            await _storage.SaveAsync(products);
        }

        public async Task<FoodProduct?> GetByIdAsync(Guid id)
        {
            var products = await _storage.LoadAsync();
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}