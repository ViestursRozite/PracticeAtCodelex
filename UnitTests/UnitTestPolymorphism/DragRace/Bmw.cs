using System;

namespace DragRace
{
    public class Bmw : CarClass, ICar
    {
        public Bmw(int acceleration, int brakingPower)
        {
            this.currentSpeed = 0;
            this.acceleration = acceleration;
            this.brakingPower = brakingPower;
            this.engineSound = "Rrrrrrr.....";
        }
        public new string CarType()
        {
            return $"{this.GetType()}";
        }
    }
}