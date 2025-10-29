using Gerenciamento.Funcionario.Application.Models;
using Gerenciamento.Funcionario.Application.Models.Requests;
using Gerenciamento.Funcionario.Application.Models.Responses;
using Gerenciamento.Funcionarios.Domain.Entities;
using Gerenciamento.Funcionarios.Domain.ValueObjects;

namespace Gerenciamento.Funcionario.Application.Mappers
{
    public static class CompanyMapper
    {
        public static Company ToCompanyDomain(this CompanyRequest company)
        {
            var companyAddresses = company.Addresses.Select(x => x.ToAddressDomain());
            return new Company(company.Id, company.Name, company.CNPJ, companyAddresses);
        }

        public static Address ToAddressDomain(this AddressModel address)
        {
            return new Address(address.Road, address.City, address.State, address.CEP);
        }

        public static CompanyResponse ToCompanyResponse(this Company company)
        {
            return new CompanyResponse(company.Id, company.Name, company.CNPJ, company.Addresses);
        }

        public static Address ToAddressModel(this Address address)
        {
            return new Address(address.Road, address.City, address.State, address.CEP);
        }
    }
}