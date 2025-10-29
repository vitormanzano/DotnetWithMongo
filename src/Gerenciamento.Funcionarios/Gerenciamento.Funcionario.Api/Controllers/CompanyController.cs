using Gerenciamento.Funcionario.Application.Interfaces;
using Gerenciamento.Funcionario.Application.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciamento.Funcionario.Api.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class CompanyController(ICompanyService companyService) : Controller
    {
        private readonly ICompanyService companyService = companyService;

        [HttpPost]
        [Route("addEmpresa", Name = nameof(AddCompany))]
        public async Task<IActionResult> AddCompany([FromBody] CompanyRequest companyRequest)
        {
            await companyService.AddAsync(companyRequest);
            return Created();
        }

        [HttpDelete]
        [Route("deleteEmpresa", Name = nameof(DeleteCompany))]
        public async Task<IActionResult> DeleteCompany([FromBody] Guid id)
        {
            await companyService.DeleteAsync(id);
            return Ok();
        }

        [HttpPatch]
        [Route("updateEmpresa/{id:guid}", Name = nameof(UpdateCompany))]
        public async Task<IActionResult> UpdateCompany(Guid id, CompanyRequest companyRequest)
        {
            var company = await companyService.FindOneAsync(id);

            await companyService.UpdateAsync(companyRequest);
            return Accepted();
        }
    }
}