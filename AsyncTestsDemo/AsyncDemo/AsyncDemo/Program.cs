using AsyncDemo.AsyncComputers;
using AsyncDemo.Computers;
using System;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var startTime = DateTime.Now;
            var fastComputer = new FastComputer();
            var mediumComputer = new MediumComputer();
            var slowComputer = new SlowComputer();

            //fastComputer.Compute();
            //mediumComputer.Compute();
            //slowComputer.Compute();

            await Task.Run(() => fastComputer.Compute());
            //await Task.Run(() => mediumComputer.Compute());
            //await Task.Run(() => slowComputer.Compute());




            var fastAsyncComputer = new FastAsyncComputer();
            var mediumAsyncComputer = new MediumAsyncComputer();
            var slowAsyncComputer = new SlowAsyncComputer();

            var fastTask = await fastAsyncComputer.Compute();
            var mediumTask = mediumAsyncComputer.Compute();
            var slowTask = slowAsyncComputer.Compute();

            //Task.WaitAll(fastTask, mediumTask, slowTask);

            //var list = new List<Task> { fastTask, mediumTask };
            //var task = await Task.WhenAny(list);

            Console.WriteLine($"Total time: {DateTime.Now.Subtract(startTime).TotalSeconds}");


            Console.ReadLine();






        }
    }
}
