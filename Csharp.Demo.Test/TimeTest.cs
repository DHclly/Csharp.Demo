using System;

namespace Csharp.Demo.Test
{
    class TimeTest
    {
        class DynamicSample
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public int Add(int a, int b)
            {
                return a + b;
            }
        }
        public static void Test()
        {
            dynamic a = 5;
            dynamic obj = new DynamicSample();
            obj.Name = "johh";
            obj.Value = "ba";
            Console.WriteLine(obj);
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start(); //  开始监视代码
            for (int i = 0; i < 10000000; i++)
            {
                //DynamicSample dynamicSample = new DynamicSample();
                //var addMethod = typeof(DynamicSample).GetMethod("Add");
                //int res = (int)addMethod.Invoke(dynamicSample, new object[] { 1, 2 });
                dynamic dynamicSample2 = new DynamicSample();
                int re2 = dynamicSample2.Add(1, 2);
            }

            stopwatch.Stop(); //  停止监视
            Console.WriteLine("time:" + stopwatch.Elapsed.Milliseconds);
            Console.ReadLine();
        }
    }
}
