using AutoMapper;
using EStore.Models.Dtos;
using EStoreAPI.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDtoController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductDtoController(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await productRepository.GetItems();

                var prodDtos = mapper.Map<IEnumerable<ProductDto>>(products);

                if (products == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(prodDtos);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetItem(int id)
        {
            try
            {
                var product = await productRepository.GetItem(id);
                var prodDto = mapper.Map<ProductDto>(product);
                if (product == null)
                {
                    return NotFound();
                }
                else
                {
                    var productCategory = await productRepository.GetCategory(product.CategoryId);
                    prodDto.CategoryId = productCategory.Id;
                    prodDto.CategoryName = productCategory.Name;
                    return Ok(prodDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
