using System;
using Xunit;
using Hierarchy;

namespace TestProjectPolymorphism
{
    public class UnitTest2
    {
        Mouse mouse = new Mouse("MouseName", 10, 12, "LivingRegionSomething1");
        Tiger tiger = new Tiger("TigerName", 100, 120, "LivingRegionSomething2");

       [Fact]
        public void Eat_InMouseFoodAndAmmount5_OutHalfEatenFood()
        {
            //Arrange
            Food food = new Vegitable(9);
            int expected = 4;
            //Act
            mouse.Eat(food, 5);
            //Assert
            Assert.Equal(expected, food.Quantity) ;
        }

        [Fact]
        public void Eat_InTigerFoodAndAmmount50_OutHalfEatenFood()
        {
            //Arrange
            Food food = new Meat(90);
            int expected = 40;
            //Act
            tiger.Eat(food, 50);
            //Assert
            Assert.Equal(expected, food.Quantity);
        }

    }
}
