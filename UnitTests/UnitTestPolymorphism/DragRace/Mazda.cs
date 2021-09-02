using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Mazda : CarClass, ICar, IBoost
    {
        public Mazda(int acceleration, int brakingPower, int currcurrentSpeed, string engineSound = "Rrrrrrr.....") :
            base(acceleration, brakingPower, engineSound) { }
        public void UseNitrousOxideEngine()
        {
            this.CurrentSpeed = this.CurrentSpeed + (2 * this.Acceleration);
        }
        public new string CarType()
        {
            return $"{this.GetType()}";
        }

        void ICar.StartEngine()
        {
            base.StartEngine();
        }
    }
}
