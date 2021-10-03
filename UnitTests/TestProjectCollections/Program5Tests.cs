using System;
using Xunit;
using WordCount;
using System.IO;

namespace TestProjectCollections
{
    public class Program5Tests
    {
        [Fact]
        public void WordCount_InString_Out2Lines()
        {
            //Arrange
            int expected = 2;
            //Act
            int[] arr = Program5.WordCount("asdas asd asdasd asd asd\njk iuj");
            int actual = arr[0];
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordCount_InString_Out7words()
        {
            //Arrange
            int expected = 7;
            //Act
            int[] arr = Program5.WordCount("asdas asd asdasd asd asd\njk iuj");
            int actual = arr[1];
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordCount_InString_Out25Chars()
        {
            //Arrange
            int expected = 25;
            //Act
            int[] arr = Program5.WordCount("asdas asd asdasd asd asd\njk iuj");
            int actual = arr[2];
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void WordCount_InString_Out31MachineChars()
        {
            //Arrange
            int expected = 31;
            //Act
            int[] arr = Program5.WordCount("asdas asd asdasd asd asd\njk iuj");
            int actual = arr[3];
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
