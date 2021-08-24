using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Meat : Food
    {
        public Meat(int quantity) : base(quantity)
        {
            base.FoodClass = "Meat";
        }
    }
}
