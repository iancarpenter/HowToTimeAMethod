using System;
using System.Diagnostics;

namespace HowToTimeAMethod
{
    class Program
    {
        /// <summary>
        /// Find out out long a method takes to execute
        /// Will form the basis of a blog post
        /// </summary>
        
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();

            for(int i = 0; i < 1000000; i++)
            {
                // do nothing
            }

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine($"Elapsed ms: {elapsedMs}");

            var elapsed = watch.Elapsed;
            Console.WriteLine($"Elapsed: {elapsed}");
        }
    }
}
