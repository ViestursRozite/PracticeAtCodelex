using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> soundMakers = new List<ISound>();
            soundMakers.Add(new Firework());
            soundMakers.Add(new Radio());
            soundMakers.Add(new Parrot());
            
            foreach(ISound noisy in soundMakers)
            {
                noisy.PlaySound();
            }
            Console.ReadKey();
        }
    }
}