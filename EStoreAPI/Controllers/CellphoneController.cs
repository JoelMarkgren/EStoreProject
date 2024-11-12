using EStoreAPI.Data.Interfaces;
using EStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CellphoneController : ControllerBase
    {
        private readonly ICellphoneRepository cellphoneRepo;

        public CellphoneController(ICellphoneRepository cellphoneRepo)
        {
            this.cellphoneRepo = cellphoneRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var cellphones = await cellphoneRepo.GetAllCellphones();
                return Ok(cellphones);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var cellphone = await cellphoneRepo.GetCellphoneById(id);
                if (cellphone == null)
                {
                    return NotFound();
                }
                return Ok(cellphone);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("create")]
        public async Task Post([FromBody] Cellphone cellphone)
        {
            await cellphoneRepo.CreateAsync(cellphone);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Cellphone cellphone, int id)
        {
            if (id != cellphone.Id)
            {
                return BadRequest("ID Mismatch");
            }
            var existingCellphone = await cellphoneRepo.GetCellphoneById(id);
            if (existingCellphone == null)
            {
                return NotFound();
            }
            await cellphoneRepo.EditAsync(cellphone, id);
            return NoContent();
        }
    }
}