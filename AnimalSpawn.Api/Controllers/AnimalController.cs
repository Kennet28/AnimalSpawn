using Microsoft.AspNetCore.Mvc;
using AnimalSpawn.Domain.Interfaces;
using System.Threading.Tasks;
using AnimalSpawn.Domain.Entities;
using AnimalSpawn.Domain.DTOs;
using System;
using System.Collections.Generic;
using AutoMapper;
using AnimalSpawn.Api.Responses;

namespace AnimalSpawn.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _service;
        private readonly IMapper _mapper;

        public AnimalController(IAnimalService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var animals = await _service.GetAnimals();
            var animalsDto = _mapper.Map<IEnumerable<Animal>, IEnumerable<AnimalResponseDto>>(animals);
            var response = new ApiResponse<IEnumerable<AnimalResponseDto>>(animalsDto);
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var animal = await _service.GetAnimal(id);
            var animalDto = _mapper.Map<Animal, AnimalResponseDto>(animal);
            var response = new ApiResponse<AnimalResponseDto>(animalDto);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(AnimalRequestDto animalDto)
        {
            var animal = _mapper.Map<AnimalRequestDto, Animal>(animalDto);
            await _service.AddAnimal(animal);
            var animalresponseDto = _mapper.Map<Animal, AnimalResponseDto>(animal);
            var response = new ApiResponse<AnimalResponseDto>(animalresponseDto);
            return Ok(response);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAnimal(id);
            var response = new ApiResponse<bool>(true);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, AnimalRequestDto animalDto)
        {
            var animal = _mapper.Map<Animal>(animalDto);
            animal.Id = id;
            animal.UpdateAt = DateTime.Now;
            animal.UpdatedBy = 2;
             await _service.UpdateAnimal(animal);
            var response = new ApiResponse<bool>(true);
            return Ok(response);
        }
    }
}