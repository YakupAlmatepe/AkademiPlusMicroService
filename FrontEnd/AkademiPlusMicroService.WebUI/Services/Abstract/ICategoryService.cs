using AkademiPlusMicroService.Sharedd.DTOs;
using AkademiPlusMicroService.WebUI.DTOs;
using AkademiPlusMicroService.WebUI.DTOs.CategoryDtos;

namespace AkademiPlusMicroService.WebUI.Services.Abstract
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDto>>> GetAllCategories();

        Task<Response<ResultCategoryDto>> GetByIdCategory(string id);

        Task<Response<NoContent>> CreateCategory(CreateCategoryDto createCategoryDto);

        Task<Response<NoContent>> UpdateCategory(UpdateCategoryDto updateCategoryDto);

        Task<Response<NoContent>> DeleteCategory(string id);
    }
}
