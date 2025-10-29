using Gerenciamento.Funcionarios.Domain.ValueObjects;
using MongoDB.Bson.Serialization.Attributes;

namespace Gerenciamento.Funcionarios.Domain.Entities
{
    public class Company(Guid id, string name, string cnpj, IEnumerable<Address> addresses)
    {
        [BsonId]
        public Guid Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string CNPJ { get; set; } = cnpj;
        public IEnumerable<Address> Addresses { get; set; } = addresses;
    }
}
