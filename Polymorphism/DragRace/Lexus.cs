using System;

namespace DragRace
{
    public class Lexus : CarClass, ICar, IBoost
    {
        public Lexus(int acceleration, int brakingPower)
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