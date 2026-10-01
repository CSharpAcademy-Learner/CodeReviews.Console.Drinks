using System.Net.Http.Json;
using static Drinks.CSharpAcademyLearner.Models.Models;

namespace Drinks.CSharpAcademyLearner.Services
{
    internal class ApiService
    {
        private readonly HttpClient _httpClient;
        private const string baseAddress = "https://www.thecocktaildb.com/api/json/v1/1/";

        internal ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(baseAddress);
            _httpClient.Timeout = TimeSpan.FromSeconds(10);
        }

        internal async Task<List<string>?> GetCategoriesAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<DrinkCategoryResponse>("list.php?c=list");

                return response?.Drinks
                .Where(c => !string.IsNullOrWhiteSpace(c.CategoryName))
                .Select(c => c.CategoryName)
                .OrderBy(c => c)
                .ToList();
            }
            catch
            {
                return null;
            }
        }

        internal async Task<List<DrinksInCategory>?> GetDrinksInCategoryAsync(string category)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<DrinksInCategoryResponse>($"filter.php?c={category}");

                return response?.Drinks
                    .Where(d => !string.IsNullOrWhiteSpace(d.Name))
                    .OrderBy(d => d.Name)
                    .ToList();
            }
            catch
            {
                return null;
            }
        }

        internal async Task<DrinkInfo?> GetDrinkInfoByIDAsync(string drinkID)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<DrinkInfoResponse>($"lookup.php?i={drinkID}");

                return response?.Drinks.FirstOrDefault();

            }
            catch
            {
                return null;
            }
        }

        internal async Task<byte[]?> GetDrinkThumbnailAsync(string thumbnailURL)
        {
            try
            {
                var response = await _httpClient.GetByteArrayAsync(thumbnailURL);

                return response;
            }
            catch
            {
                return null;
            }
        }
    }
}
