using System;

namespace DragRace
{
    public class Audi : CarClass, ICar
    {
        public Audi(int acceleration, int brakingPower)
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