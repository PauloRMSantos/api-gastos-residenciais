using gastosResidenciais.DTOs;
using gastosResidenciais.Interfaces;
using gastosResidenciais.Models;
using Microsoft.AspNetCore.Mvc;

namespace gastosResidenciais.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController(ICategoryService categoryService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetCategoriesAsync()
    {
        var response = await categoryService.GetCategoriesAsync();
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategoryAsync([FromBody] CreateCategoryDTO category)
    {
        var response = await categoryService.CreateCategoryAsync(category);
        return Ok(response);
    }
}