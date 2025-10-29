using Gerenciamento.Funcionario.Application.Interfaces;
using Gerenciamento.Funcionario.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Gerenciamento.Funcionarios.CrossCutting.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICompanyService, CompanyService>();
            return services;
        }
    }
}
