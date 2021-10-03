using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public abstract class CarClass
    {
        protected int CurrentSpeed { get; set; }
        protected int Acceleration { get; set; }
        protected int BrakingPower { get; set; }
        protected string EngineSound { get; set; }
        
        public CarClass(int acceleration, int brakingPower, string engineSound, int currentSpeed = 0)
        {
            this.CurrentSpeed = 0;
            this.Acceleration = acceleration;
            this.BrakingPower = brakingPower;
            this.EngineSound = engineSound;
        }

        public virtual void SpeedUp()
        {
            CurrentSpeed = CurrentSpeed + Acceleration;
        }

        public void SlowDown()
        {
            CurrentSpeed = CurrentSpeed - BrakingPower;
        }

        public string ShowCurrentSpeed()
        {
            return CurrentSpeed.ToString();
        }

        public string StartEngine()
        {
            Console.WriteLine(EngineSound);
            return EngineSound;
        }
        public string CarType()
        {
            return $"{this.GetType()}";
        }
    }
}
