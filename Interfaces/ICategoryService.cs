using gastosResidenciais.DTOs;
using gastosResidenciais.Models;

namespace gastosResidenciais.Interfaces;

public interface ICategoryService
{
    public Task<IEnumerable<Category>> GetCategoriesAsync();
    public Task<Category> CreateCategoryAsync(CreateCategoryDTO categoryDto);
}