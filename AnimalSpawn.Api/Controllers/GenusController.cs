
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
        private readonly IGenusRepository _repository;

        // private readonly AnimalSpawnContext _context;
        public GenusController(IGenusRepository repository)
        {
            _repository=repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Genus = await _repository.GetAllGenus();
            return Ok(Genus);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var animal = await _repository.GetGenus(id);
            return Ok(animal);
        }

    }
}