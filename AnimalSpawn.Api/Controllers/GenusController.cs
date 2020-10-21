
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Repositories;
using AnimalSpawn.Domain.Entities;

namespace AnimalSpawn.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenusController : ControllerBase
    {
        private readonly IRepository<Genus>  _repository;

        // private readonly AnimalSpawnContext _context;
        public GenusController(IRepository<Genus> repository)
        {
            _repository=repository;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var Genus = await _repository.GetAll();
        //    return Ok(Genus);
        //}
        //[HttpGet("{id:int}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    var Genus = await _repository.GetById(id);
        //    return Ok(Genus);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Post(AnimalRequestDto animalDto)
        //{
        //    var animal = _mapper.Map<AnimalRequestDto, Animal>(animalDto);
        //    await _service.AddAnimal(animal);
        //    var animalresponseDto = _mapper.Map<Animal, AnimalResponseDto>(animal);
        //    var response = new ApiResponse<AnimalResponseDto>(animalresponseDto);
        //    return Ok(response);
        //}
        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    await _service.DeleteAnimal(id);
        //    var response = new ApiResponse<bool>(true);
        //    return Ok(response);
        //}

        //[HttpPut]
        //public async Task<IActionResult> Put(int id, AnimalRequestDto animalDto)
        //{
        //    var animal = _mapper.Map<Animal>(animalDto);
        //    animal.Id = id;
        //    animal.UpdateAt = DateTime.Now;
        //    animal.UpdatedBy = 2;
        //    await _service.UpdateAnimal(animal);
        //    var response = new ApiResponse<bool>(true);
        //    return Ok(response);
        //}
    }
}