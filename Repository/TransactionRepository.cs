using gastosResidenciais.Models;
using gastosResidenciais.Repository.Interfaces;

namespace gastosResidenciais.Repository;

public class TransactionRepository(AppDbContext context): BaseRepository<Transaction>(context), ITransactionRepository { }