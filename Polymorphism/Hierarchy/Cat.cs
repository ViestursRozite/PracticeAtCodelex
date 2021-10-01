using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat : Feline
    {
        public string Breed { get; }
        private string _sound = "Mnnnnnauu";
        public Cat(string animalName, double animalWeight, int foodEaten, string livingRegion, string breed, string animalType = "Cat") :
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine(this._sound);
        }
    }
}
