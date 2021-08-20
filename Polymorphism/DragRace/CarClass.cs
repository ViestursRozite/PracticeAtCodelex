using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public abstract class CarClass
    {
        protected int currentSpeed { get; set; }
        protected int acceleration { get; set; }
        protected int brakingPower { get; set; }
        protected string engineSound { get; set; }
        public virtual void SpeedUp()
        {
            currentSpeed = currentSpeed + acceleration;
        }
        public void SlowDown()
        {
            currentSpeed = currentSpeed - brakingPower;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine(engineSound);
        }
        public string CarType()
        {
            return $"{this.GetType()}";
        }
    }
}
