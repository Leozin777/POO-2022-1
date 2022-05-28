using CrudClient.Models.Domain;
using CrudClient.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CrudClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DebtContoller : ControllerBase
    {
        private IDebtRepository repository;
        public DebtContoller(IDebtRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IEnumerable<Debt>Get()
        {
            return repository.GetAll();
        }

        [HttpPost()]
        public IActionResult Post([FromBody]Debt debt)
        {
            repository.Create(debt);
            return Ok(new{
                message = "Cobrança cadastrada com sucesso",
                httpCode = 202,
                objectCreated = debt
            });
        }
            
    }
}
