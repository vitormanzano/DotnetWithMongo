namespace Gerenciamento.Funcionarios.Domain.ValueObjects
{
    public record Address
    {
        public string Road { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string CEP { get; init; }

        public Address(string road, string city, string state, string cep) 
        {
            Road = road;
            City = city;
            State = state;
            CEP = cep;
        }
    }
}
