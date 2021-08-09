using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog Max, Rocky, Sparky, Buster, Sam, Lady, Molly, Coco;

            Max = new Dog("Max", "male");
            Rocky = new Dog("Rocky", "male");
            Sparky = new Dog("Sparky", "male");
            Buster = new Dog("Buster", "male");
            Sam = new Dog("Sam", "male");
            Lady = new Dog("Lady", "female");
            Molly = new Dog("Molly", "female");
            Coco = new Dog("Coco", "female");

            Max.Mother = Lady;
            Max.Father = Rocky;

            Coco.Mother = Molly;
            Coco.Father = Buster;

            Rocky.Mother = Molly;
            Rocky.Father = Sam;

            Buster.Mother = Lady;
            Buster.Father = Sparky;

            Console.WriteLine(Coco.FathersName());
            Console.WriteLine(Sparky.FathersName());

            Console.WriteLine(Coco.HasSameMotherAs(Rocky));
            Console.WriteLine(Coco.HasSameMotherAs(Buster));
        }
    }
}
