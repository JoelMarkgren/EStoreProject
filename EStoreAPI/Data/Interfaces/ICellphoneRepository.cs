using EStoreAPI.Models;

namespace EStoreAPI.Data.Interfaces
{
    public interface ICellphoneRepository
    {
        Task<IEnumerable<Cellphone>> GetAllCellphones();
        Task<Cellphone> GetCellphoneById(int id);
        Task CreateAsync(Cellphone cellphone);
        Task<Cellphone> EditAsync(Cellphone cellphone, int id);
        Task DeleteAsync(int id);
    }
}
