using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        public static string GetString(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            string userInput = "";
            userInput = Console.ReadLine();
            Console.WriteLine($"string read ({userInput})");
            return userInput;
        }
        public static decimal GetDecimal(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            decimal userInput = -1;
            decimal.TryParse(Console.ReadLine(), out userInput);
            if (userInput == 1) 
            {
                Console.WriteLine("Failed to read try again");
                GetDecimal(messageToUser);
            }
            Console.WriteLine($"number read ({userInput})");
            return userInput;
        }
        public static Animal SpawnAnimal()
        {
            string animalType = "";
            bool loop = true;
            Animal someAnimal = null;
            while (loop)
            {
                animalType = GetString("Enter one of the folowing:\n" +
                "Mouse\n" +
                "Cat\n" +
                "Zebra\n" +
                "Tiger\n");

                if (animalType.Equals("Mouse"))
                {
                    loop = false;
                    someAnimal = (new Mouse(
                        GetString("Enter the name of this creature:\n"),
                        (double)GetDecimal("Enter animal weight:\n"),
                        (int)GetDecimal("Enter food needed to feed this creature:\n"),
                        GetString("Enter living envireoment of this creature:\n")
                        ));
                }
                if (animalType.Equals("Zebra"))
                {
                    loop = false;
                    someAnimal = (new Zebra(
                        GetString("Enter the name of this creature:\n"),
                        (double)GetDecimal("Enter animal weight:\n"),
                        (int)GetDecimal("Enter food needed to feed this creature:\n"),
                        GetString("Enter living envireoment of this creature:\n")
                        ));
                }
                if (animalType.Equals("Tiger"))
                {
                    loop = false;
                    someAnimal = (new Tiger(
                        GetString("Enter the name of this creature:\n"),
                        (double)GetDecimal("Enter animal weight:\n"),
                        (int)GetDecimal("Enter food needed to feed this creature:\n"),
                        GetString("Enter living envireoment of this creature:\n")
                        ));
                }
                if (animalType.Equals("Cat"))
                {
                    loop = false;
                    someAnimal = (new Cat(
                        GetString("Enter the name of this creature:\n"),
                        (double)GetDecimal("Enter animal weight:\n"),
                        (int)GetDecimal("Enter food needed to feed this creature:\n"),
                        GetString("Enter living envireoment of this creature:\n"),
                        GetString("Enter breed of this creature:\n")
                        ));
                }
            }
            return someAnimal;
        }

        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();

            zoo.Add(new Mouse("Jerry", 0.010, 1, "Indoor pest"));
            zoo.Add(new Zebra("Marty", 400, 500, "Savanna"));
            zoo.Add(new Cat("Tom", 8, 5, "Indoor pet", "Grey shorthair"));
            zoo.Add(new Tiger("Alex", 300, 80, "Savanna"));

            zoo.Add(SpawnAnimal());//Makes animals from user input

            foreach(Mammal animal in zoo)
            {
                animal.MakeSound();
                Food meat, vegetable;
                
                meat = new Meat(1);
                vegetable = new Vegitable(1);
                animal.Eat(meat, 1);
                Console.WriteLine($"meat remaining: {meat.Quantity}");
                animal.Eat(vegetable, 1);
                Console.WriteLine($"vegetables remaining: {vegetable.Quantity}");

                string catBreed = "breed unknown";
                if (animal is Cat cat) catBreed = cat.Breed;

                Console.WriteLine($"{animal.AnimalType} [{animal.AnimalName}, {catBreed}, Animal\'s weigth: {animal.AnimalWeight}, {animal.LivingRegion }, {animal.FoodEaten}]");
                Console.WriteLine();
            }
        }
    }
}