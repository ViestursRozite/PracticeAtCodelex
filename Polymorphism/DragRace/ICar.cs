using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    public interface ICar
    {
        string CarType();
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
        //1. Extract common behaviour to an interface called Car, and use it in the all classes.
        //* Which methods will be extracted with an empty body, and which can be default?
    }
}
