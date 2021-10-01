using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    public class Poster : Advert
    {
        double[] dimentions = new double[2];
        int NumberOfPosters { get; }
        double CostPerCopy { get; }
        public Poster(int fee, double dimensionX, double dimensionY, int number, double costPerCopy) : base(fee)
        {
            this.dimentions[0] = dimensionX;
            this.dimentions[1] = dimensionY;
            this.NumberOfPosters = number;
            this.CostPerCopy = costPerCopy;
        }
    }
}
