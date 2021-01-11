using System.Threading;

namespace AsyncDemo.Computers
{
    public class FastComputer : IComputer
    {
        public void Compute()
        {
            Thread.Sleep(2 * 1000);
        }
    }
}
