using AnimalBirdAPI.Models;
using AnimalBirdAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AnimalBirdAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BirdController : ControllerBase
    {
        private IBirdService _birdService;

        public BirdController(IBirdService birdService)
        {
            _birdService = birdService;
        }

        [HttpGet]
        public async Task<ActionResult<Bird>> Get()
        {
            var bird = await _birdService.GetBirdAsync();

            return bird;
        }
    }
}
