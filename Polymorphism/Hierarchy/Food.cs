using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Food
    {
        public int Quantity { get; set; }
        public string FoodClass { get; set; }
        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
