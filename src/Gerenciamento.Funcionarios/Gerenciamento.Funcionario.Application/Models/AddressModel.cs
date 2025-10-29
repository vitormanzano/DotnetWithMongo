namespace Gerenciamento.Funcionario.Application.Models
{
    public class AddressModel(string road, string city, string state, string cep)
    {
        public string Road { get; init; } = road;
        public string City { get; init; } = city;
        public string State { get; init; } = state;
        public string CEP { get; init; } = cep;
    }
}
