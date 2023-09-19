using AkademiPlusMicroService.Shared.Dtos;
using AkademiPusMicroservice.Catalog.DTOs.CategoryDtos;
using AkademiPusMicroservice.Catalog.DTOs.ProductDtos;

namespace AkademiPusMicroservice.Catalog.Services.ProductService
{

    public interface IProductService
    {
        Task<Response<List<CreateProductDto>>> GetAllProducts();
        Task<Response<ResultProductDto>> GetCategoryById(string id);
        Task<Response<NoContent>> CreateCategory(CreateProductDto createProductDto);
        Task<Response<NoContent>> UpdateCategory(UpdateProductDto updateProductDto);
        Task<Response<NoContent>> DeleteCategory(string id);
    }
}