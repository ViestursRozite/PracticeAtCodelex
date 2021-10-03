using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Vegitable: Food
    {
        public Vegitable(int quantity) : base(quantity)
        {
            base.FoodClass = "Vegitable";
        }
    }
}
