namespace gastosResidenciais.Repository.Interfaces;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task addAsync (T entity);
    Task updateAsync (T entity);
    Task deleteAsync (T entity);
}