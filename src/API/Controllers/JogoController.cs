using System.Threading.Tasks;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : ControllerBase
    {
        private readonly IJogoRepository jogoRepository;
        public JogoController(IJogoRepository jogoRepository)
        {
            this.jogoRepository = jogoRepository;

        }

        [Route("{name}/name")]
        public async Task<IActionResult> GetJogosByName(string name)
        {
            try
            {
                return Ok(await this.jogoRepository.GetJogosByName(name));
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}