using System;
using System.Diagnostics;
namespace csharp.demo.test
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            Csharp.Demo.Keyword_class.NestedClass.GeometricShape.Demo.Run();
            stopwatch.Stop();
            Console.WriteLine("耗时："+stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
