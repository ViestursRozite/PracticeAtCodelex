﻿
using System;

namespace GravityCalculator
{
    public class Program7
    {
        public static double DoGravity()
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double fallingTimeSquared = fallingTime * fallingTime;
            double initialPosition = 0.0;
            double finalPosition = 0.0;

            finalPosition = initialPosition + (0.5 * ((gravity * fallingTimeSquared) + initialVelocity));

            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            return finalPosition;
        }

        static void Main(string[] args)
        {
            DoGravity();
            Console.ReadKey();
        }
    }
}
