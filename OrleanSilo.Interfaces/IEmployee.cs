using System.Threading.Tasks;
using Orleans;

namespace OrleanSilo.Interfaces
{
    public interface IEmployee : IGrainWithGuidKey
    {
        Task Greeting(IEmployee from, string message);

        Task<int> GetLevel();
        Task Promote(int newLevel);

        Task<IManager> GetManager();
        Task SetManager(IManager manager);
    }
}