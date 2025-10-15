using Mato.Domain;
using Mato.Interfaces;
using Microsoft.JSInterop;
using System.Text.Json;

namespace Mato.Services
{
    public class JsFoodStorage : IFoodStorage
    {
        private readonly IJSRuntime _js;
        private const string StorageKey = "foodProducts";

        public JsFoodStorage(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<List<FoodProduct>> LoadAsync()
        {
            var json = await _js.InvokeAsync<string>("foodStorage.loadProducts");
            return string.IsNullOrWhiteSpace(json)
                ? new List<FoodProduct>()
                : JsonSerializer.Deserialize<List<FoodProduct>>(json) ?? new List<FoodProduct>();
        }

        public async Task SaveAsync(List<FoodProduct> products)
        {
            var json = JsonSerializer.Serialize(products);
            await _js.InvokeVoidAsync("foodStorage.saveProducts", json);
        }
    }
}