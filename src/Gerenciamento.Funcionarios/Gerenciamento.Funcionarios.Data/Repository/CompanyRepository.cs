using Gerenciamento.Funcionarios.Domain.Entities;
using Gerenciamento.Funcionarios.Domain.Interfaces;
using MongoDB.Driver;

namespace Gerenciamento.Funcionarios.Data.Repository
{
    public class CompanyRepository(IMongoDatabase mongoDb) : BaseRepository<Company>(mongoDb, "Company"), ICompanyRepository
    {
    }
}
