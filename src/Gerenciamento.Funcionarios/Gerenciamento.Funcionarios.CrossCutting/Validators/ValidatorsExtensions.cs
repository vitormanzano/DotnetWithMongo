using FluentValidation;
using FluentValidation.AspNetCore;
using Gerenciamento.Funcionario.Application.Models;
using Gerenciamento.Funcionario.Application.Models.Requests;
using Gerenciamento.Funcionario.Application.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace Gerenciamento.Funcionarios.CrossCutting.Validators
{
    public static class ValidatorsExtensions
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation(x => x.DisableDataAnnotationsValidation = true);
            services.AddScoped<IValidator<CompanyRequest>, AddCompanyValidator>();
            services.AddScoped<IValidator<AddressModel>, AddAddressValidator>();
            return services;
        }
    }
}
