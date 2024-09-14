using AnimalBirdAPI.Models;
using System.Threading.Tasks;

namespace AnimalBirdAPI.Services
{
    public class ReptileService : IReptileService
    {
        public Task<IEnumerable<string>> GetTurtlesAsync()
        {
            var turtles = new List<string> { "Leatherback", "Green Turtle", "Loggerhead" };
            return Task.FromResult<IEnumerable<string>>(turtles);
        }

        public Task<IEnumerable<string>> GetLizardsAsync()
        {
            var lizards = new List<string> { "Gecko", "Iguana", "Komodo Dragon" };
            return Task.FromResult<IEnumerable<string>>(lizards);
        }
    }
}
