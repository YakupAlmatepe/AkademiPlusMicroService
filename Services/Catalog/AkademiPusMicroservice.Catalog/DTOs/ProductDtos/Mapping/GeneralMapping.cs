using AkademiPusMicroservice.Catalog.DTOs.CategoryDtos;
using AkademiPusMicroservice.Catalog.Models;
using AutoMapper;

namespace AkademiPusMicroservice.Catalog.DTOs.ProductDtos.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
             CreateMap<Category,ResultCategoryDto>().ReverseMap();
             CreateMap<Category,CreateCategoryDto>().ReverseMap();
             CreateMap<Category,UpdateCategoryDto>().ReverseMap();

             CreateMap<Product,UpdateProductDto>().ReverseMap();
             CreateMap<Product,CreateProductDto>().ReverseMap();
             CreateMap<Product,UpdateProductDto>().ReverseMap();

           
        }
    }
}
