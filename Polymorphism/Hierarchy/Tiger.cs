using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        private string _sound = "RAAAWRR";
        public Tiger(string animalName, double animalWeight, int foodEaten, string livingRegion, string animalType = "Tiger") :
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        { }
        public override void Eat(Food food, int quantity)
        {
            if (food.FoodClass.Equals("Meat"))
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
