using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    class Radio: ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("BZZZ Shhh.. parrot has learned to imitate fireworks");
        }
    }
}
