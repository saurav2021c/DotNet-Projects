using AnimalBirdAPI.Models;
using System.Threading.Tasks;

namespace AnimalBirdAPI.Services
{
    public class DogService : IDogService
    {
        public Task<Dog> GetDogAsync()
        {
            var dog = new Dog
            {
                Name = "Dog",
                Sound = "Bark"
            };
            return Task.FromResult(dog);
        }
    }
}
