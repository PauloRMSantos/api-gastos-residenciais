using gastosResidenciais.DTOs;
using gastosResidenciais.Interfaces;
using gastosResidenciais.Models;
using gastosResidenciais.Repository.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace gastosResidenciais.Services;

public class CategoryService(IUnitOfWork unitOfWork) : ICategoryService
{
    public async Task<IEnumerable<Category>> GetCategoriesAsync()
    {
        var categories = await unitOfWork.Categories.GetAllAsync();
        return categories;
    }

    public async Task<Category> CreateCategoryAsync(CreateCategoryDTO categoryDto)
    {
        var category = new Category().Create(
            categoryDto.Description,
            categoryDto.Type
            );
        await unitOfWork.Categories.addAsync(category);
        await unitOfWork.CommitAsync();
        
        return category;
    }
}