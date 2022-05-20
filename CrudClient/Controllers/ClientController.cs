using System.Collections.Generic;
using CrudClient.Models.Domain;
using CrudClient.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CrudClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private IClientRepository repository;
        public ClientController(IClientRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IEnumerable<Client>Get()
        {
            return repository.GetAll();
        }

        [HttpPost()]
        public IActionResult Post([FromBody]Client client)
        {
            repository.Create(client);
            return Ok(client);
        }

        [HttpPut()]
        public IActionResult Put([FromBody]Client client)
        {
            repository.Update(client);
            return Ok(client);
        }
            
    }
}