using System.Threading;

namespace AsyncDemo.Computers
{
    public class MediumComputer : IComputer
    {
        public void Compute()
        {
            Thread.Sleep(5 * 1000);
        }
    }
}
