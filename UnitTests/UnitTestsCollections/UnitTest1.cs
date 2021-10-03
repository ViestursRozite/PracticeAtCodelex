using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace UnitTestsCollections
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WordCount_InPath_OutSymbolCount()
        {
            //Arrange
            int expected = 5;
            //Act
            int[] arr = Program5.WordCount("asdas asd asdasd asd asd");
            int actual = arr[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
