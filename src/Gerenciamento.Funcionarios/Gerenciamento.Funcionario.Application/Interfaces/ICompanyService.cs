using Gerenciamento.Funcionario.Application.Models.Requests;
using Gerenciamento.Funcionario.Application.Models.Responses;

namespace Gerenciamento.Funcionario.Application.Interfaces
{
    public interface ICompanyService
    {
        Task<CompanyResponse> FindOneAsync(Guid id);
        Task AddAsync(CompanyRequest company);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(CompanyRequest company);
    }
}
