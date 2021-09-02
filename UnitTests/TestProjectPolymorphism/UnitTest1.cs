using System;
using Xunit;
using DragRace;

namespace TestProjectPolymorphism
{
    public class UnitTest1
    {
        CarClass car = new Lexus(9,8,0);

        [Fact]
        public void SpeedUp_InNothing_OutCarObjectIncresesSpeed()
        {
            //Arrange
            string expected = "9";
            //Act
            car.SpeedUp();
            //Assert
            string actual= car.ShowCurrentSpeed();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SlowDown_InNothing_OutCarSlows()
        {
            //Arrange
            string expected = "1";
            //Act
            car.SpeedUp();
            car.SlowDown();
            //Assert
            string actual = car.ShowCurrentSpeed();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_InNothing_OutCarSpeedAsString()
        {
            //Arrange
            string expected = "9";
            car.SpeedUp();
            //Act
            string actual = car.ShowCurrentSpeed();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_InNothing_OutCarEngineSoundString()
        {
            //Act
            var actual = car.StartEngine();
            //Assert
            Assert.IsType<string>(actual);
        }

        [Fact]
        public void CarType_InNothing_OutCarType()
        {
            //Assert
            Assert.IsType<Lexus> (car);
        }
    }
}
