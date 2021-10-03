using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Mazda : CarClass, ICar, IBoost
    {
        public Mazda(int acceleration, int brakingPower)
        {
            this.currentSpeed = 0;
            this.acceleration = acceleration;
            this.brakingPower = brakingPower;
            this.engineSound = "Rrrrrrr.....";
        }
        public void UseNitrousOxideEngine()
        {
            this.currentSpeed = this.currentSpeed + (2 * this.acceleration);
        }
        public new string CarType()
        {
            return $"{this.GetType()}";
        }
    }
}
