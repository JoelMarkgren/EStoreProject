using EStoreBlazorWASM.Models;

namespace EStoreBlazorWASM.Services.Interfaces
{
    public interface ICellphoneService
    {
        Task<IEnumerable<CellphoneViewModel>> GetAllAsync();
        Task<CellphoneViewModel> GetAsync(int id);
        Task DeleteAsync(int id);
        Task<CellphoneViewModel> CreateAsync();
        Task UpdateAsync(CellphoneViewModel cellphone, int id);

    }
}
