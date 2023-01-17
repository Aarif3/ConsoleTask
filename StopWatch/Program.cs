using System.Diagnostics;
namespace StopWatch
{


    internal class Program
    {
          
        static async Task Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();


            Console.WriteLine("Hello word");
            //waiting for 5000 milisecond
            await Task.Delay(5000);
            sw.Stop();
            var timeTaken = sw.ElapsedMilliseconds;
            Console.WriteLine($"Time Take is {timeTaken}");
        }
    }
}