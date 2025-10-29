using Gerenciamento.Funcionarios.Domain.ValueObjects;

namespace Gerenciamento.Funcionario.Application.Models.Requests
{
    public class CompanyRequest(Guid id, string nome, string cnpj, IEnumerable<AddressModel> addresses)
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = nome;
        public string CNPJ { get; set; } = cnpj;
        public IEnumerable<AddressModel> Addresses { get; set; } = addresses;
    }
}
