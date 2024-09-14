using AnimalBirdAPI.Models;
using AnimalBirdAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AnimalBirdAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReptileController : ControllerBase
    {
        private readonly IReptileService _reptileService;

        public ReptileController(IReptileService reptileService)
        {
            _reptileService = reptileService;
        }

        [HttpGet("turtles")]
        public async Task<ActionResult<IEnumerable<string>>> GetTurtles()
        {
            var turtles = await _reptileService.GetTurtlesAsync();
            return Ok(turtles);
        }

        [HttpGet("lizards")]
        public async Task<ActionResult<IEnumerable<string>>> GetLizards()
        {
            var lizards = await _reptileService.GetLizardsAsync();
            return Ok(lizards);
        }
    }
}
