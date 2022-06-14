using Microsoft.AspNetCore.Mvc;
using TdeCrudAvancado.Model.Domain;
using TdeCrudAvancado.Model.Repositories;

namespace TdeCrudAvancado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository repository;
        public  ClientController(IClientRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IEnumerable<Client> Get()
        {
            return repository.GetAll();
        }
    }
}