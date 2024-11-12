using EStoreAPI.Data.Interfaces;
using EStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EStoreAPI.Data.Repos
{
    public class CellphoneRepository : ICellphoneRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CellphoneRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        

        public async Task<IEnumerable<Cellphone>> GetAllCellphones()
        {
            return await applicationDbContext.Cellphones.OrderBy(x => x.Model).ToListAsync();
        }

        public async Task<Cellphone> GetCellphoneById(int id)
        {
            return await applicationDbContext.Cellphones.FirstOrDefaultAsync(x => x.Id == id);

        }
        public async Task CreateAsync(Cellphone cellphone)
        {
            if (cellphone == null)
            {
                throw new ArgumentNullException(nameof(cellphone));
            }
            await applicationDbContext.Cellphones.AddAsync(cellphone);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var cellphone = await applicationDbContext.Cellphones.FindAsync(id);
            applicationDbContext.Cellphones.Remove(cellphone);
            await applicationDbContext.SaveChangesAsync();
        }
        public async Task<Cellphone> EditAsync(Cellphone cellphone, int id)
        {
            var editedCellphone = await applicationDbContext.Cellphones.FindAsync(id);
            editedCellphone.Color = cellphone.Color;
            editedCellphone.Model = cellphone.Model;
            editedCellphone.Price = cellphone.Price;
            editedCellphone.Image = cellphone.Image;

            await applicationDbContext.SaveChangesAsync();
            return editedCellphone;
        }
    }
}
