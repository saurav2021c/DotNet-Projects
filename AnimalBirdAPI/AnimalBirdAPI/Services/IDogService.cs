using AnimalBirdAPI.Models;
using System.Threading.Tasks;

namespace AnimalBirdAPI.Services
{
    public interface IDogService
    {
        Task<Dog> GetDogAsync();
    }
}
