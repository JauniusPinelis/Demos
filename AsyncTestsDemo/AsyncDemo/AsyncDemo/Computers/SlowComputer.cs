using System.Threading;

namespace AsyncDemo.Computers
{
    public class SlowComputer : IComputer
    {
        public void Compute()
        {
            Thread.Sleep(8 * 1000);
        }
    }
}
