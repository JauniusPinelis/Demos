using System.Threading.Tasks;

namespace AsyncDemo.AsyncComputers
{
    public class FastAsyncComputer
    {
        public async Task<bool> Compute()
        {
            await Task.Delay(3 * 1000);
            return true;
        }
    }
}
