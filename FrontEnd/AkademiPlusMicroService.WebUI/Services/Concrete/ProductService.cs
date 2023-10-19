using AkademiPlusMicroService.Sharedd.DTOs;
using AkademiPlusMicroService.WebUI.DTOs;
using AkademiPlusMicroService.WebUI.Services.Abstract;

namespace AkademiPlusMicroService.WebUI.Services.Concrete
{
    public class ProductService : IProductService
    {
        public Task<Response<NoContent>> CreateProduct(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ResultProductDto>>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ResultProductDto>> GetByIdProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateProduct(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}