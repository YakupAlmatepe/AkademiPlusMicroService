using AkademiPlusMicroService.Shared.Dtos;
using AkademiPusMicroservice.Catalog.DTOs.CategoryDtos;
using AkademiPusMicroservice.Catalog.DTOs.ProductDtos;

namespace AkademiPusMicroservice.Catalog.Services.ProductService
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetAllCategories();

        Task<Response<ResultProductDto>> GetByIdProduct(string id);
        Task<Response<NoContent>> CreateProduct(CreateProductDto createProductDto);

        Task<Response<NoContent>> UpdateProduct(UpdateProductDto updateProductDto);



        Task<Response<NoContent>> DeleteProduct(string id);
    }
}
