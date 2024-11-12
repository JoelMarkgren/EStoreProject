using AutoMapper;
using EStore.Models.Dtos;
using EStoreAPI.Models;

namespace EStoreAPI.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
            .ForMember(p => p.CategoryName, o => o.MapFrom(src => src.Category.Name));
        }
    }
}
