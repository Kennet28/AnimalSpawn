
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Repositories;

namespace AnimalSpawn.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenusController : ControllerBase
    {
        private readonly IAnimalRepository _repository;

        // private readonly AnimalSpawnContext _context;
        public GenusController(IAnimalRepository repository)
        {
            _repository=repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Genus = await _repository.GetGenus();
            return Ok(Genus);
        }

        
    }
}