using System;
using System.Threading;
namespace clock{
    public delegate void ClockHandler(object sender, ClockEventargs args);
    public class ClockEventargs{
        public int hour{ get; set; }
        public int minute{ get; set; }
        public int second{ get; set; }
    }
    public class Clock
    {
        public event ClockHandler OnTick;
        public event ClockHandler OnAlarm;
        public int Hour, Minute, Second, alarmHour, alarmMinute;
        bool runClock=true;
        public Clock(int hour,int minute,int second){
            if(hour<=23&&hour>=0&&minute<=59&&minute>=0&&second<=59&&second>=0){
                this.Hour = hour;
                this.Minute = minute;
                this.Second = second;
            }
            else
                throw new ArgumentOutOfRangeException("时钟时间错误");
        }
        public void setAlarm(int hour,int minute){
            if(hour<=23&&hour>=0&&minute<=59&&minute>=0){
                this.alarmHour = hour;
                this.alarmMinute = minute;
            }
            else
                throw new ArgumentOutOfRangeException("闹钟设置错误");
        }
        public void turnoffClock(){
            runClock = false;
        }
        public void TickTok(){
            while(runClock){
                if(this.Second<=59){
                    this.Second++;
                }
                else{
                    this.Minute++;
                    this.Second = 0;
                }
                if(this.Minute>=60){
                    this.Minute = 0;
                    this.Hour = (this.Hour++) % 24;
                }
                ClockEventargs args = new ClockEventargs() { hour = Hour, minute = Minute, second = Second };
                if(this.Hour==this.alarmHour&&this.Minute==this.alarmMinute&&this.Second==0){
                    OnAlarm(this,args);
                    runClock = false;
                }
                else
                    OnTick(this,args);
                Thread.Sleep(1000);
            }
        }
        public class NewClock{
            public Clock newClock;
            public NewClock(int hour,int minute,int second){
                newClock = new Clock(hour, minute, second);
                newClock.OnTick += this.OnTick;
                newClock.OnAlarm += this.OnAlarm;
            }
            public void OnTick(object sender,ClockEventargs args){
                Console.WriteLine("Tick Tok!");
            }
            public void OnAlarm(object sender,ClockEventargs args){
                Console.WriteLine("RingRingRing!");
            }
        }
        public class Program{
            static void Main(string[] args){
                try{
                    NewClock myClock = new NewClock(12, 30, 0);
                    myClock.newClock.setAlarm(12, 32);
                    myClock.newClock.TickTok();
                }
                catch(ArgumentOutOfRangeException e){
                    Console.WriteLine("时间设置出错了");
                }
                Console.ReadKey();
            }
        }
    }
}