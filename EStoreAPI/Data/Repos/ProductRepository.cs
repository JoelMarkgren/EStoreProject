using EStoreAPI.Data.Interfaces;
using EStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EStoreAPI.Data.Repos
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await applicationDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await applicationDbContext.ProductCategories.FirstOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await applicationDbContext.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await applicationDbContext.Products
                .Include(p => p.Category)
                .ToListAsync();
            return products;
        }
    }
}
