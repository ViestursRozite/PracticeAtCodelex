using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace 
{
    class Lada : CarClass, ICar
    {
        public Lada(int acceleration, int brakingPower, int currcurrentSpeed, string engineSound = "Brbrrrr....") :
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
