using Microsoft.AspNetCore.Mvc;
using TdeCrudAvancado.DTOs;
using TdeCrudAvancado.Model.Domain;
using TdeCrudAvancado.Model.Repositories;
using TdeCrudAvancado.ViewModel;

namespace TdeCrudAvancado.Controllers
{
    [Route("api/")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository repository;
        private readonly IUnityOfWork unityOfWork;
        
        public ClientController(IClientRepository clientRepository, IUnityOfWork unityOfWork)
        {
            this.repository = clientRepository;
            this.unityOfWork = unityOfWork;
        }

        [HttpGet("v1/clients")]
        public async Task<IActionResult> getAll()
        {
            var clientList = await repository.getAll();

            List<ClientDTO> clientsDTO = new List<ClientDTO>();

            foreach (Client client in clientList)
            {
                var clientDTO = new ClientDTO()
                {
                    Id = client.Id,
                    Name = client.Name,
                    BirthDay = client.BirthDay,
                    PhoneNumber = client.PhoneNumber
                };
                clientsDTO.Add(clientDTO);
            }
            return Ok(clientsDTO);
        }

        [HttpGet("v1/clients/{id:int}")]
        public async Task<IActionResult> getById([FromRoute]int id)
        {
            var client = await repository.getById(id);

            if(client == null)
                return NotFound();
            else
            {
                var clientDTO = new ClientDTO()
                {
                    Id = client.Id,
                    Name = client.Name,
                    BirthDay = client.BirthDay,
                    PhoneNumber = client.PhoneNumber
                };
                return Ok(clientDTO);
            }    
        }

        [HttpPost("v1/clients")]
        public async Task<IActionResult> post([FromBody] ClientCreateViewModel model)
        {
            var client = new Client()
            {
                Name = model.Name,
                BirthDay = model.BirthDay,
                PhoneNumber = model.PhoneNumber
            };
            repository.Create(client);
            await unityOfWork.commit();

            return Ok(new
            {
                message = "Cliente " + client.Name + " foi cadastrado :)"
            });
        }

        [HttpDelete("v1/clients/{id:int}")]
        public async Task<IActionResult> delete([FromRoute] int id)
        {
            var clientDel = repository.Delete(id);
            await unityOfWork.commit();

            if(clientDel == false)
                return NotFound();
            else
                return Ok(id);    
        }

        [HttpPatch("v1/clients/{id:int}")]
        public async Task<IActionResult> PutAsync([FromRoute] int id, [FromBody] ClientUpdateViewModel model)
        {
            var client = await repository.getById(id);
            
            if(client == null)
                return NotFound();
            else
            {
                client.Name = model.Name;
                client.PhoneNumber = model.PhoneNumber;

                repository.Update(client);

                var clientDTO = new ClientDTO()
                {
                    Id = client.Id,
                    Name = client.Name,
                    BirthDay = client.BirthDay,
                    PhoneNumber = client.PhoneNumber
                };
                return Ok(clientDTO);
            }    
        }
    }
}