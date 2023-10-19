using AkademiPlusMicroService.Sharedd.DTOs;
using AkademiPlusMicroService.WebUI.Services.Abstract;
using AkademiPlusMicroService.WebUI.DTOs;
using AkademiPlusMicroService.WebUI.DTOs.CategoryDtos;

namespace AkademiPlusMicroService.WebUI.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpClientFactory _httpClient;

        public Task<Response<NoContent>> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> DeleteCategory(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ResultCategoryDto>>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ResultCategoryDto>> GetByIdCategory(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
