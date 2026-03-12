namespace gastosResidenciais.Repository.Interfaces;

public interface IUnitOfWork : IDisposable
{
    ICategoryRepository Categories { get; }
    IPersonRepository Persons { get; }
    ITransactionRepository Transactions { get; }
    Task<int> CommitAsync();
}