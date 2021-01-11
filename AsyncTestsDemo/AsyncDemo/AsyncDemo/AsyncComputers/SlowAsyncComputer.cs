using System.Threading.Tasks;

namespace AsyncDemo.AsyncComputers
{
    public class SlowAsyncComputer : IAsyncComputer
    {
        public async Task Compute()
        {
            await Task.Delay(8 * 1000);
        }
    }
}
