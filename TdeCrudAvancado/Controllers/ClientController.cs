using Microsoft.AspNetCore.Mvc;

namespace TdeCrudAvancado.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "ok";
        }
    }
}