using System;
using System.Threading;

namespace csharp.demo.keyword_lock
{
    public class Account
    {
        private readonly object _lock = new Object();
        private int _num;
        private readonly Random _random;

        private Account(int num)
        {
            _num = num;
            _random = new Random();
        }

        private int WithDraw(int amount)
        {
            if (_num < 0)
            {
                Console.WriteLine(_num);
                throw new Exception("负值");
            }
            lock (_lock)
            {
                if (_num >= amount)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine(DateTime.Now.Millisecond + '\n');
                    Console.WriteLine("num执行WithDraw方法前：" + _num);
                    Console.WriteLine("要减去的数值amount：" + amount);
                    _num -= amount;
                    Console.WriteLine("num执行WithDraw方法后：" + _num);
                    Console.WriteLine("++++++++++++++++++++++++++++++++");
                    return amount;
                }
                return 0;
            }
        }

        private void DoTransactions()
        {
            for (int i = 0; i <100 ; i++)
            {
                WithDraw(_random.Next(1, 100));
            }
        }

        public static void Run()
        {
            int num = 10;
            Thread[] threads = new Thread[num];
            Account acc = new Account(num * 100);
            for (int i = 0; i < num; i++)
            {
                threads[i] = new Thread(acc.DoTransactions);
            }
            for (int i = 0; i < num; i++)
            {
                threads[i].Start();
            }
        }
    }
}
