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
            Run(10000000);
            stopwatch.Stop();
            Console.WriteLine("耗时："+stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }

        public static void Run(int num)
        {
            var count = 0;
            for (int i = 0; i <=num; i++)
            {
                foreach (char c in i.ToString().ToCharArray())
                {
                    if (int.Parse(c.ToString()) == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("count:"+count);
        }
    }
}
