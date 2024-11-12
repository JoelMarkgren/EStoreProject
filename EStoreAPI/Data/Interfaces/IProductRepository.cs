using EStoreAPI.Models;

namespace EStoreAPI.Data.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<ProductCategory> GetCategory(int id);
        Task<Product> GetItem(int id);

    }
}
