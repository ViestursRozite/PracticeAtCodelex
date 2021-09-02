using System;

namespace DragRace
{
    public class Tesla : CarClass, ICar
    {
        public Tesla(int acceleration, int brakingPower, int currcurrentSpeed, string engineSound = "-- silence ---") :
            base(acceleration, brakingPower, engineSound){ }

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