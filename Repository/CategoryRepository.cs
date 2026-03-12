using gastosResidenciais.Models;
using gastosResidenciais.Repository.Interfaces;

namespace gastosResidenciais.Repository;

public class CategoryRepository(AppDbContext context) : BaseRepository<Category>(context), ICategoryRepository { }