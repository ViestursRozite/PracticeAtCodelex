using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise6;

namespace UnitTestsCode
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void MakeTwoSeperateArrs_Input10And1And100And7_out2DifferentArrays()
        {
            //Arrange
            int[] array1;
            int[] array2;
            //Act
            Loops.MakeTwoSeperateArrs(10, 1, 100, -7, out array1, out array2);
            //Assert 
            Assert.AreNotEqual(array1, array2);
        }

        [TestMethod]
        public void MakeTwoSeperateArrs_Input10And1And100And7_AlButLastElementsMatch()
        {
            //Arrange
            int[] array1;
            int[] array2;
            bool areEqual = true;
            //Act
            Loops.MakeTwoSeperateArrs(10, 1, 100, -7, out array1, out array2);
            for (int i = 0; i < array1.Length - 1; i++)
            {
                if (array1[i] != array2[i]) areEqual = false;
            }
            //Assert 
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void MakeTwoSeperateArrs_Input10And1And100And7_ArrayElementsInRange1To100()
        {
            //Arrange
            int[] array1;
            int[] array2;
            bool elementsCheckOut = true;
            //Act
            Loops.MakeTwoSeperateArrs(10, 1, 100, -7, out array1, out array2);
            foreach(int number in array2)
            {
                if (!(number >= 1 || number <= 100)) elementsCheckOut = false;
            }
            //Assert 
            Assert.IsTrue(elementsCheckOut);
        }
    }
}
