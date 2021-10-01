using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        private string _sound = "*ultrasonic noises";
        public Mouse(string animalName, double animalWeight, int foodEaten, string livingRegion, string animalType = "Mouse"):
            base(animalName, animalType, animalWeight, foodEaten, livingRegion) { }

        public override void Eat(Food food, int quantity)
        {
            if(food.FoodClass.Equals("Vegitable"))
            {
                base.Eat(food, quantity);
            }
            else
            {
                Console.WriteLine($"{base.AnimalType} do not eat that type of food!");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine(this._sound);
        }
    }
}
