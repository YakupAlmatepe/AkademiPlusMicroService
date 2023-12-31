﻿using AkademiPusMicroservice.Catalog.DTOs.CategoryDtos;
using AkademiPusMicroservice.Catalog.Services.CategoryService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPusMicroservice.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategoryList()
        {
            var values = await _categoryService.GetAllCategories();
            return Ok(values);
        }

        [HttpPost]

        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategory(createCategoryDto);
            return Ok("Kategori eklendi");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteCategory(string id)
        {
            await _categoryService.DeleteCategory(id);
            return Ok("Kategori silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateCategory(updateCategoryDto);
            return Ok("Güncelleme yapıldı");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetCategoryById(string id)
        {
            var values = await _categoryService.GetByIdCategory(id);

            return Ok(values);
        }
    }
}