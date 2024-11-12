using EStore.Models.Dtos;

namespace EStoreBlazorWASM.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
        Task<ProductDto> GetItem(int id);
    }
}
