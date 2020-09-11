
using AnimalSpawn.Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using AnimalSpawn.Api.Models;

namespace AnimalSpawn.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var animals = new AnimalRepository().GetAnimals();
            return Ok(animals);
        }
    }
}