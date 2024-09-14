using AnimalBirdAPI.Models;
using AnimalBirdAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnimalBirdAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogController : ControllerBase
    {
        IDogService _dogService;

        public DogController(IDogService dogService)
        {
            _dogService = dogService;
        }

        [HttpGet]
        public async Task<ActionResult<Dog>> Get()
        {
            var dog = await _dogService.GetDogAsync();

            return dog;
        }
    }
}
