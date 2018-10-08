using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class SetAlarmClockArgs : EventArgs//声明参数类型
    {
        public DateTime setAlarmClock;
    }
    public delegate void SetAlarmClockHandler(object sender, SetAlarmClockArgs e);//声明委托类型
    
    public class AlarmClock//定义事件源
    {
        //声明事件
        public event SetAlarmClockHandler SetAlarm;
        public DateTime now = DateTime.Now;
        public void SetAlarmClock(DateTime alarm)
        {
            SetAlarmClockArgs yourAlarmClock = new SetAlarmClockArgs();
            yourAlarmClock.setAlarmClock = alarm;
            while (now <= alarm)
            {
                now = DateTime.Now;
            }
            SetAlarm(this, yourAlarmClock);
        }
    }
    class program1
    {
        static void Main(string[] args)
        {
            var alarmClock = new AlarmClock();
            alarmClock.SetAlarm += ShowAlarm;
            string day = Console.ReadLine();//注册事件
            string hour = Console.ReadLine();
            string minute = Console.ReadLine();

            int iday = int.Parse(day);
            int ihour = int.Parse(hour);
            int iminute = int.Parse(minute);
            DateTime alarm = new DateTime(2018, 10, iday, ihour, iminute, 00);
            if (alarmClock.now > alarm)
            {
                Console.WriteLine("You input wrong clock, please input new one again!");
                Console.Write("Done!!!");
            }
            else
            {
                alarmClock.SetAlarmClock(alarm);
                Console.WriteLine("Done!");
            }
        }
        static void ShowAlarm(object sender, SetAlarmClockArgs e)//事件处理方法
        {
            Console.WriteLine($"Alarm......Now is {e.setAlarmClock}");
        }
    }
}
