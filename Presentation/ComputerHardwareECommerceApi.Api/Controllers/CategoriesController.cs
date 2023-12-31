using ComputerHardwareECommerceApi.Application.DataServices;
using ComputerHardwareECommerceApi.Application.Dtos.Category;
using ComputerHardwareECommerceApi.Application.RequestParemeters;
using ComputerHardwareECommerceApi.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComputerHardwareECommerceApi.Api.Controllers
{

    public class CategoriesController : CustomBaseController
    {
        private readonly IDataService<Category,CategoryDto> _categoryService;

        public CategoriesController(IDataService<Category, CategoryDto> categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories([FromQuery] Pagination pagination) 
        => CreateActionResult(await _categoryService.GetAllAsync(pagination));
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCategory(string id)
        =>CreateActionResult(await _categoryService.GetByIdAsync(id));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(string id)
        =>CreateActionResult(await _categoryService.DeleteAsync(id));

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryCreateDto category)
        =>CreateActionResult(await _categoryService.AddAsync(category));

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryUpdateDto category)
        =>CreateActionResult(await _categoryService.UpdateAsync(category));

    }
}
