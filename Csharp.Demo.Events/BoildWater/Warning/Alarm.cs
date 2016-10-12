using System;

namespace CSharp.Demo.Events.BoildWater.Warning
{
    class Alarm
    {
        public void MakeAlert(Object sender, Heater.BoiledEventArgs e)
        {
            Heater heater = (Heater)sender; //这里是不是很熟悉呢？
            //访问 sender 中的公共字段
            Console.WriteLine("Alarm：({0} - {1}): ", heater.Area, heater.Type);
            Console.WriteLine("------------------");
            if (e.Temperature == 100)
            {
                Console.WriteLine("Alarm:水已经开了");
                Console.WriteLine("Alarm:已经停止烧水");
            }
            else
            {
                Console.WriteLine("Alarm: 嘀嘀嘀，水已经 {0} 度了。", e.Temperature);
            }
            Console.WriteLine();
        }
    }
}
