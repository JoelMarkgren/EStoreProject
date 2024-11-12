using EStore.Models.Dtos;
using EStoreBlazorWASM.Models;
using EStoreBlazorWASM.Services.Interfaces;
using System.Diagnostics;
using System.Net.Http.Json;

namespace EStoreBlazorWASM.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/ProductDto");
                return products;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<ProductDto> GetItem(int id)
        {
            try
            {
                var product = await httpClient.GetFromJsonAsync<ProductDto>($"api/ProductDto/{id}");
                return product;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
