using System;
using CSharp.Demo.Events.BoildWater.Warning;

namespace CSharp.Demo.Events.BoildWater
{
    public sealed class Heater
    {
        public class BoiledEventArgs : EventArgs
        {
            private readonly int _temperature;

            public BoiledEventArgs(int temperature)
            {
                this._temperature = temperature;
            }

            public int Temperature
            {
                get { return _temperature; }
            }
        }

        private int _temperature;
        private string _type = "国美";
        private string _area = "中国";

        public string Type
        {
            get { return _type; }
        }

        public string Area
        {
            get { return _area; }
        }

        public delegate void BoiledEventHandler(Object sender, BoiledEventArgs args);

        public event BoiledEventHandler Boiled;

        private void OnBoiled(BoiledEventArgs args)
        {
            var handler = Boiled;
            if (handler != null)
                handler(this, args);
        }

        public void BoilWater()
        {
            for (int i = 0; i <=100; i++)
            {
                _temperature = i;
                if (_temperature>95)
                {
                    BoiledEventArgs eventArgs = new BoiledEventArgs(_temperature);
                    OnBoiled(eventArgs);
                }
            }
        }

        public static void Run()
        {
            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            heater.Boiled += alarm.MakeAlert; //注册方法
            //heater.Boiled += new Alarm().MakeAlert; //给匿名对象注册方法
            //heater.Boiled += new Heater.BoiledEventHandler(alarm.MakeAlert); //也可以这么注册
            //heater.Boiled += Display.ShowMessage; //注册静态方法
            heater.BoilWater(); //烧水，会自动调用注册过对象的方法
        }
    }
}
