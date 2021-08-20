using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace 
{
    class Lada : CarClass, ICar
    {
        public Lada(int acceleration, int brakingPower)
        {
            this.currentSpeed = 0;
            this.acceleration = acceleration;
            this.brakingPower = brakingPower;
            this.engineSound = "Brbrrrr....";
        }
        public new string CarType()
        {
            return $"{this.GetType()}";
        }
    }
}
