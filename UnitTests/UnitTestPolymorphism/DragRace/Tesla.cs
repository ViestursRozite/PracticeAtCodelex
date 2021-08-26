using System;

namespace DragRace
{
    public class Tesla : CarClass, ICar
    {
        public Tesla(int acceleration, int brakingPower)
        {
            this.currentSpeed = 0;
            this.acceleration = acceleration;
            this.brakingPower = brakingPower;
            this.engineSound = "-- silence ---";
        }
        public new string CarType()
        {
            return $"{this.GetType()}";
        }
    }
}