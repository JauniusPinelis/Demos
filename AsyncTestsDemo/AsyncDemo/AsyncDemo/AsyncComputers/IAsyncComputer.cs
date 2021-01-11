using System.Threading.Tasks;

namespace AsyncDemo.AsyncComputers
{
    public interface IAsyncComputer
    {
        Task Compute();
    }
}
