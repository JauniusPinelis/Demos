using System.Threading.Tasks;

namespace AsyncDemo.AsyncComputers
{
    public class MediumAsyncComputer : IAsyncComputer
    {
        public async Task Compute()
        {
            await Task.Delay(5 * 1000);
        }
    }
}
