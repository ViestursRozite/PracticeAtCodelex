using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName;
        public  string AnimalType;
        public double AnimalWeight;
        public int FoodEaten;

        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = foodEaten;
        }

        public abstract void MakeSound();
        
        public virtual void Eat(Food food, int quantity)
        {
            food.Quantity -= quantity;
        }
    }
}
