using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.demo.time
{
    public class Time
    {
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public long GetTimeStamp(DateTime time)
        {
            TimeSpan span = (time - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());
             return (long)span.TotalSeconds;
        }
        /// <summary>
        /// 获取本地时间
        /// </summary>
        /// <param name="timestamp"></param>
        /// <returns></returns>
        public DateTime GetLocalTime(long timestamp)
        {
            DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateTime newDateTime = start.AddSeconds(timestamp);
            return newDateTime.ToLocalTime();
        }
        public static void Run()
        {
            var time = new Time();
            var a = time.GetTimeStamp(DateTime.Now);
            var t = time.GetLocalTime(a);
            Console.WriteLine(a);
            Console.WriteLine(t);
        }
    }
}
