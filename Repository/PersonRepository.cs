using gastosResidenciais.Models;
using gastosResidenciais.Repository.Interfaces;

namespace gastosResidenciais.Repository;

public class PersonRepository(AppDbContext context) : BaseRepository<Person>(context), IPersonRepository{ }