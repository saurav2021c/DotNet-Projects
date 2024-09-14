using AnimalBirdAPI.Models;
using System.Threading.Tasks;

namespace AnimalBirdAPI.Services
{
    public class BirdService : IBirdService
    {
        public Task<Bird> GetBirdAsync()
        {
            var bird = new Bird
            {
                Name = "Bird",
                Sound = "Chirp"
            };
            return Task.FromResult(bird);
        }
    }
}
