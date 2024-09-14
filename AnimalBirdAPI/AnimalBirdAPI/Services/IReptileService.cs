using AnimalBirdAPI.Models;
using System.Threading.Tasks;

namespace AnimalBirdAPI.Services
{
    public interface IReptileService
    {
        Task<IEnumerable<string>> GetTurtlesAsync();
        Task<IEnumerable<string>> GetLizardsAsync();
    }
}
