using System.Threading.Tasks;

using Bored.Core.Models;

namespace Bored.Core.Interfaces
{
    public interface IActivityRepository
    {
        Task<Activity> GetRandomActivityAsync();
    }
}
