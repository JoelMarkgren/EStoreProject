using EStoreBlazorWASM.Models;
using EStoreBlazorWASM.Services.Interfaces;
using System.Net;
using System.Net.Http.Json;

namespace EStoreBlazorWASM.Services
{
    public class CellphoneService : ICellphoneService
    {
        private readonly HttpClient httpClient;

        public CellphoneService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<CellphoneViewModel> CreateAsync(CellphoneViewModel cellphone)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync<CellphoneViewModel>("api/Cellphone", cellphone);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<CellphoneViewModel>();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CellphoneViewModel>> GetAllAsync()
        {
            try
            {
                var cellphones = await httpClient.GetFromJsonAsync<IEnumerable<CellphoneViewModel>>("api/Cellphone");
                return cellphones;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<CellphoneViewModel> GetAsync(int id)
        {
            try
            {
                var cellphone = await httpClient.GetFromJsonAsync<CellphoneViewModel>("api/Cellphone");
                return cellphone;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public Task UpdateAsync(CellphoneViewModel cellphone, int id)
        {
            throw new NotImplementedException();
        }

        Task<CellphoneViewModel> ICellphoneService.CreateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
