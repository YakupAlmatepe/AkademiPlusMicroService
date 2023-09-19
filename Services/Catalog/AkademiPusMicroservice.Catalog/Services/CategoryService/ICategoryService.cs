using AkademiPlusMicroService.Shared.Dtos;
using AkademiPusMicroservice.Catalog.DTOs.CategoryDtos;

namespace AkademiPusMicroservice.Catalog.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<Response<List<ResultCategoryDto>>> GetAllCategories();
        Task<Response<ResultCategoryDto>> GetCategoryById(string id);
        Task<Response<NoContent>> CreateCategory(CreateCategoryDto createCategoryDto);
        Task<Response<NoContent>> UpdateCategory(UpdateCategoryDto updateCategoryDto);
        Task<Response<NoContent>> DeleteCategory(string id);
    }
}