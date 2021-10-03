using System;

namespace DragRace
{
    public class Bmw : CarClass, ICar
    {
        public Bmw(int acceleration, int brakingPower, int currcurrentSpeed, string engineSound = "Rrrrrrr.....") :
            base(acceleration, brakingPower, engineSound)
        { }
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