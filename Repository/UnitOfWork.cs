using gastosResidenciais.Repository.Interfaces;

namespace gastosResidenciais.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public ICategoryRepository Categories { get; }
    public IPersonRepository Persons { get; }
    public ITransactionRepository Transactions { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        Categories = new CategoryRepository(context);
        Persons = new PersonRepository(context);
        Transactions = new TransactionRepository(context);
    }

    public async Task<int> CommitAsync() =>
        await _context.SaveChangesAsync();

    public void Dispose() =>
        _context.Dispose();
}