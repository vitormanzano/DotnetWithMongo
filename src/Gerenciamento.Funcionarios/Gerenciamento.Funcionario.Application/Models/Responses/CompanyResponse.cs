using System.Xml.Linq;
using Gerenciamento.Funcionarios.Domain.ValueObjects;

namespace Gerenciamento.Funcionario.Application.Models.Responses
{
    public class CompanyResponse(Guid id, string name, string cnpj, IEnumerable<Address> addresses)
    {
        public Guid Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string CNPJ { get; set; } = cnpj;
        public IEnumerable<Address> Addresses { get; set; } = addresses;
    }
}
