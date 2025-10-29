using FluentValidation;
using Gerenciamento.Funcionario.Application.Models;
using Gerenciamento.Funcionario.Application.Models.Requests;

namespace Gerenciamento.Funcionario.Application.Validators
{
    public class AddCompanyValidator : AbstractValidator<CompanyRequest>
    {
        public AddCompanyValidator() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O id não pode ser vazio!");

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("O nome não pode ser vazio ou nulo!");

            RuleFor(x => x.CNPJ)
                .NotNull()
                .NotEmpty()
                .WithMessage("O CNPJ não pode ser vazio!");
        }
    }

    public class AddAddressValidator : AbstractValidator<AddressModel>
    {
        public AddAddressValidator()
        {
            RuleFor(x => x.Road)
                .NotNull()
                .NotEmpty()
                .WithMessage("A rua não pode ser vazio ou nulo!");

            RuleFor(x => x.City)
                .NotNull()
                .NotEmpty()
                .WithMessage("A cidade não pode ser vazio ou nulo!");

            RuleFor(x => x.State)
                .NotNull()
                .NotEmpty()
                .WithMessage("O Estado não pode ser vazio ou nulo!");

            RuleFor(x => x.CEP)
                .NotNull()
                .NotEmpty()
                .WithMessage("O CEP não pode ser vazio!");
        }
    }
}
