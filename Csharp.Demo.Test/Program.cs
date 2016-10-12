using System;
using System.Diagnostics;
using csharp.demo.keyword_lock;
using csharp.demo.time;
using CSharp.Demo.Events.BoildWater;

namespace csharp.demo.test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine("耗时："+stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
