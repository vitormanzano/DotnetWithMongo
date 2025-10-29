using Gerenciamento.Funcionario.Application.Interfaces;
using Gerenciamento.Funcionario.Application.Mappers;
using Gerenciamento.Funcionario.Application.Models.Requests;
using Gerenciamento.Funcionario.Application.Models.Responses;
using Gerenciamento.Funcionarios.Domain.Entities;
using Gerenciamento.Funcionarios.Domain.Interfaces;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Gerenciamento.Funcionario.Application.Services
{
    public class CompanyService(ICompanyRepository companyRepository) : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository = companyRepository;

        public async Task<CompanyResponse> FindOneAsync(Guid id)
        {
            var company = await _companyRepository.FindOneAsync(id);
            return company.ToCompanyResponse();
        }

        public async Task AddAsync(CompanyRequest company)
        {
            var companyDomain = company.ToCompanyDomain();
            await _companyRepository.AddOneAsync(companyDomain);
        }

        public async Task DeleteAsync(Guid id)
        {
            var filter = new FilterDefinitionBuilder<Company>()
                .Where(x => x.Id == id);

            await _companyRepository.DeleteAsync(_ => filter.Inject());
        }

        public async Task UpdateAsync(CompanyRequest company)
        {
            var filter = new FilterDefinitionBuilder<Company>()
                .Where(x => x.Id == company.Id);

            var companyDomain = company.ToCompanyDomain();
            await _companyRepository.ReplaceOneAsync(_ => filter.Inject(), companyDomain);
        }
    }
}
