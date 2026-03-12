using gastosResidenciais.Models;
using Microsoft.EntityFrameworkCore;

namespace gastosResidenciais.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}